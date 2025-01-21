package main

import (
	"database/sql"
	"fmt"
	"log"
	"math/rand"
	"os"
	"regexp"
	"strings"
	"time"

	"github.com/bxcodec/faker/v3"
	_ "github.com/denisenkom/go-mssqldb"
)

type Users struct {
	Id            string
	Name          string
	LastName      string
	Email         string
	RFC           string
	PasswordHash  string
	Role          int16
	IsActive      bool
	CreatedAt     time.Time
	LastUpdatedAt time.Time
}

func sanitize(input string) string {
	re := regexp.MustCompile(`[^a-zA-ZñÑ]`)
	return re.ReplaceAllString(strings.ToUpper(input), "")
}

func isVowel(char rune) bool {
	return strings.ContainsRune("AEIOU", char)
}

func getVowel(lastName string) string {
	for _, char := range lastName[1:] {
		if isVowel(char) {
			return string(char)
		}
	}
	return "X"
}

func generateRFC(name, lastName, birthDate string) string {
	lastName = sanitize(lastName)
	name = sanitize(name)

	rfc := string(lastName[0]) // Letra inicial del primer apellido
	rfc += getVowel(lastName)  // Primera vocal interna del primer apellido
	rfc += string(lastName[1]) // Letra inicial del segundo apellido
	rfc += string(name[0])     // Primera letra del nombre

	fecha, _ := time.Parse("2006-01-02", birthDate)
	rfc += fmt.Sprintf("%02d%02d%02d", fecha.Year()%100, int(fecha.Month()), fecha.Day())

	rfc += "XXX"

	return rfc
}

func generateUsers() Users {
	name := faker.FirstName()
	lastName := faker.LastName()
	email := strings.ToLower(name) + "." + strings.ToLower(lastName) + "." + fmt.Sprint(int16(rand.Intn(100))) + "@something.com"
	birthDate := faker.Date()
	parsedBirthDate, _ := time.Parse("2006-01-02", birthDate)
	rfc := generateRFC(name, lastName, parsedBirthDate.Format("2006-01-02"))

	return Users{
		Id:            faker.UUIDHyphenated(),
		Name:          name,
		LastName:      lastName,
		Email:         email,
		RFC:           rfc,
		PasswordHash:  faker.Password(),
		Role:          int16(rand.Intn(7)), // Role between 0 and 6
		IsActive:      false,
		CreatedAt:     time.Now().AddDate(-rand.Intn(10), 0, 0),
		LastUpdatedAt: time.Now().AddDate(-rand.Intn(10), 0, 0),
	}
}

func main() {
	connString := "server=localhost;user id=sa;password=wagner;port=1433;database=Wagner;encrypt=disable"

	db, err := sql.Open("sqlserver", connString)
	if err != nil {
		log.Fatal("--; Error openting the connection:", err)
	}
	defer db.Close()

	file, err := os.Create("Records.txt")
	if err != nil {
		log.Fatal("--; Error when creating the file:", err)
	}
	defer file.Close()

	//total := 3500690

	for i := 0; i < 3500690; i++ {
		user := generateUsers()

		_, err := file.WriteString(fmt.Sprintf("Id: %s, Name: %s, LastName: %s, Email: %s, RFC: %s, PasswordHash: %s, Role: %d, IsActive: %t, CreatedAt: %s, LastUpdatedAt: %s\n",
			user.Id, user.Name, user.LastName, user.Email, user.RFC, user.PasswordHash, user.Role, user.IsActive, user.CreatedAt.Format(time.RFC3339), user.LastUpdatedAt.Format(time.RFC3339)))
		if err != nil {
			log.Println("--; Error when writing the file:", err)
		}

		_, err = db.Exec(`INSERT INTO Banking.Users (Id, Name, LastName, Email, RFC, PasswordHash, Role, IsActive, CreatedAt, LastUpdatedAt)
		                  VALUES (@Id, @Name, @LastName, @Email, @RFC, @PasswordHash, @Role, @IsActive, @CreatedAt, @LastUpdatedAt)`,
			sql.Named("Id", user.Id),
			sql.Named("Name", user.Name),
			sql.Named("LastName", user.LastName),
			sql.Named("Email", user.Email),
			sql.Named("RFC", user.RFC),
			sql.Named("PasswordHash", user.PasswordHash),
			sql.Named("Role", user.Role),
			sql.Named("IsActive", user.IsActive),
			sql.Named("CreatedAt", user.CreatedAt),
			sql.Named("LastUpdatedAt", user.LastUpdatedAt),
		)

		if err != nil {
			log.Println("--; Error when injecting data:", err)
		}
	}

	fmt.Println("--; Records generated and stored in the file and database")
}
