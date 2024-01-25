using System;
using System.Collections.Generic;

namespace Repository3.Models;

public partial class Score
{
    public int ScoreId { get; set; }

    public int? SubjectId { get; set; }

    public int? Year { get; set; }

    public double? Score1 { get; set; }
}
