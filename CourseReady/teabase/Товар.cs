using System;
using System.Collections.Generic;

namespace CourseReady.teabase;

public partial class Товар
{
    public int IdТовар { get; set; }

    public string Название { get; set; } = null!;

    public string Стоимость { get; set; } = null!;

    public int? Количество { get; set; }

    public string? Категория { get; set; }

    public byte[]? Фото { get; set; }

    public virtual ICollection<КорзинаHasТовар> КорзинаHasТоварs { get; } = new List<КорзинаHasТовар>();
}
