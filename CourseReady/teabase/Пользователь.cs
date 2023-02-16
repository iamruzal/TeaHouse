using System;
using System.Collections.Generic;

namespace CourseReady.teabase;

public partial class Пользователь
{
    public int IdПользователь { get; set; }

    public string Логин { get; set; } = null!;

    public string Пароль { get; set; } = null!;

    public string Роль { get; set; } = null!;

    public virtual ICollection<Заказ> Заказs { get; } = new List<Заказ>();

    public virtual ICollection<Корзина> Корзинаs { get; } = new List<Корзина>();
}
