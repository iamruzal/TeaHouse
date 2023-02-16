using System;
using System.Collections.Generic;

namespace CourseReady.teabase;

public partial class Корзина
{
    public int IdКорзина { get; set; }

    public int ПользовательIdПользователь { get; set; }

    public virtual ICollection<КорзинаHasТовар> КорзинаHasТоварs { get; } = new List<КорзинаHasТовар>();

    public virtual Пользователь ПользовательIdПользовательNavigation { get; set; } = null!;
}
