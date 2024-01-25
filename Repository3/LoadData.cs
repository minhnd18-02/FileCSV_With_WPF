using Repository3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository3
{
    public class LoadData
    {
        private readonly FileCsvContext _context;

        public LoadData(FileCsvContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<DataStatistics> LoadStatistics()
        {
            var statistics = _context.MarkReports
                .GroupBy(score => score.Year)
                .Select(g => new DataStatistics
                {
                    Year = g.Key,
                    StudentCountAtThisYear = g.Count(),
                    CountToan = g.Count(score => score.Toan != null),
                    CountVan = g.Count(score => score.Van != null),
                    CountLy = g.Count(score => score.Ly != null),
                    CountSinh = g.Count(score => score.Sinh != null),
                    CountNgoaiNgu = g.Count(score => score.Ngoaingu != null),
                    CountHoa = g.Count(score => score.Hoa != null),
                    CountLichSu = g.Count(score => score.Lichsu != null),
                    CountDiaLy = g.Count(score => score.Dialy != null),
                    CountGDCD = g.Count(score => score.Gdcd != null)
                })
                .ToList();

            return statistics;
        }
    }
}
