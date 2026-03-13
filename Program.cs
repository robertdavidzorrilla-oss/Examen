namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            productoElectronico laptop = new productoElectronico("Laptop", "P1001", 45000, 5, 12 );
            ProductoAlimento Leche = new ProductoAlimento("Leche", "A2001", 100, 20, new DateTime(2026, 12, 31));

            Console.WriteLine("---- Producto Electronico ----");
            laptop.Mostrarproducto();
            Console.WriteLine("Impuesto: " + laptop.CalcularImpuesto());

            Console.WriteLine();

            Console.WriteLine("---- Producto Alimento ----");
            Leche.Mostrarproducto();
            Console.WriteLine("Impuesto: " + Leche.CalcularImpuesto());

            Console.ReadLine();






        }



    }

    public class Producto
    {

        private string nombre { get; set; }
        private string codigo  { get; set; }
        private double precio { get; set; }
        private double cantidad { get; set; }

        public Producto(string nombre, string codigo, double precio, double cantidad)
        {
          this.nombre = nombre;
          this.codigo = codigo;
          this.precio = precio;
          this.cantidad = cantidad;
        }

       public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }



        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }

        }

        public virtual void Mostrarproducto()
        {

            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Cantiadad: " + cantidad);
            Console.WriteLine("Precio: " + precio);

        }

        public virtual double CalcularImpuesto()
        {
            return 0;

        }




    }

    public class productoElectronico : Producto
    {
        private int garantiameses; 

        public productoElectronico(string nombre, string codigo, double precio, double cantidad,int garantiameses )
            : base(nombre, codigo, precio, cantidad)
        {
            this.garantiameses = garantiameses;

        }
        public int Garantiameses
        {
            get { return garantiameses; }
            set { garantiameses = value; }
        }
        public override void Mostrarproducto()
        {
            base.Mostrarproducto();
            Console.WriteLine("Garantia: " + garantiameses + "meses");
        }

        public override double CalcularImpuesto()
        {
            return Precio * 0.18;

        }

        





    }

    class ProductoAlimento: Producto
    {
        private DateTime fechavencimiento;

        public ProductoAlimento(string nombre, string codigo, double precio, double cantidad,DateTime fechaVencimiento)
            : base(nombre, codigo, precio, cantidad)
        {
            this.fechavencimiento = fechaVencimiento;

        }
        public DateTime FechaVencimiento
        {
            get { return fechavencimiento; }
            set { fechavencimiento = value; }

        }
        public override void Mostrarproducto()
        {
            base.Mostrarproducto();
            Console.WriteLine("Fecha de vencimiento: " + fechavencimiento.ToShortDateString());
            


            

        }

        public override double CalcularImpuesto()
        {
            return Precio * 0.08;

        }



    }
}
