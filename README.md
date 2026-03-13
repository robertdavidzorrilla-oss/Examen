# Examen 2do parcial
En este programa se desarrolló un sistema simple de gestión de inventario utilizando programación orientada a objetos en C#.
Primero se creó una clase base llamada Producto, que contiene los atributos comunes de todos los productos: nombre, código, precio y cantidad. Estos atributos se declararon como privados para aplicar encapsulación, y se accede a ellos mediante propiedades públicas. También se creó el método MostrarProducto() para mostrar la información del producto y un método CalcularImpuesto() declarado como virtual.
Luego se crearon dos clases derivadas que heredan de Producto:
ProductoElectronico, que agrega el atributo garantía en meses y sobrescribe el método CalcularImpuesto() para calcular el 18% de ITBIS.
ProductoAlimento, que agrega el atributo fecha de vencimiento y sobrescribe CalcularImpuesto() para calcular un 8% de impuesto.
Esto permite aplicar herencia y polimorfismo, ya que cada tipo de producto calcula su impuesto de manera diferente.
En el método Main(), el programa le pide al usuario que seleccione el tipo de producto y que introduzca los datos del producto como nombre, código, precio y cantidad. Dependiendo del tipo seleccionado, el programa también solicita la garantía o la fecha de vencimiento.
Finalmente, el programa muestra la información del producto y el impuesto calculado en la consola.
