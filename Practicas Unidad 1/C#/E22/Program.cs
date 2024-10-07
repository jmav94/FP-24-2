using E22;

Articulo miArticulo = new Articulo();

miArticulo.Nombre = "Juguete";
miArticulo.Precio = 10;
miArticulo.CantidadVendida = 5;

Console.WriteLine($"El IVA del {miArticulo.Nombre} es de: {miArticulo.CalcularIVA()}");
Console.WriteLine($"El Descuento del {miArticulo.Nombre} es de: {miArticulo.CalcularDescuento()}");
Console.WriteLine($"El Subtotal del {miArticulo.Nombre} es de: {miArticulo.CalcularSubtotal()}");
Console.WriteLine($"El Total de la compra es de: {miArticulo.CalcularTotal()}");
Console.WriteLine($"El Total de la compra es de: {miArticulo.CalcularIVA() + miArticulo.CalcularDescuento() + miArticulo.CalcularSubtotal()}");
