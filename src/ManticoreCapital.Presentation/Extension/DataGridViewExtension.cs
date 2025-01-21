using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Presentation.Extension
{
    public static class DataGridViewExtension
    {
        public static void UpdateGrid<T>(
               this DataGridView dgv,
               List<T> dataSource,
               int currentPage,
               int pageSize,
               out int totalPages)
        {
            // Calcular total de páginas
            int totalRecords = dataSource.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            // Calcular los registros a mostrar en la página actual
            int skip = (currentPage - 1) * pageSize;
            var paginatedData = dataSource.Skip(skip).Take(pageSize).ToList();

            // Asignar los datos paginados al DataGridView
            dgv.DataSource = paginatedData;

            // Opcional: Configurar columnas si es necesario
        }
    }
}
