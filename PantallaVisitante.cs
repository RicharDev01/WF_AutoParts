using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoparts
{
  public partial class PantallaVisitante : Form
  {
    // lista de los productos
    List<Producto> productos;

    // creacion de productos ("la base de datos")
    Producto p1;
    Producto p2;
    Producto p3;
    Producto p4;


    public PantallaVisitante()
    {
      InitializeComponent();
    }

    // para verificar si exite la instancia o no
    // si existe, que retorne la misma, sino que la cree
    public static PantallaVisitante _instanciaPantallaVisitante;

    public static PantallaVisitante GetInstanciaPantallaVisitante()
    {
      if (_instanciaPantallaVisitante == null)
      {
        _instanciaPantallaVisitante = new PantallaVisitante();
      }

      return _instanciaPantallaVisitante;
    }

    private void PantallaVisitante_Load(object sender, EventArgs e)
    {
      // lista de los productos
      productos = new List<Producto>();

      // creacion de productos ("la base de datos")
      p1 = new Producto();
      p1.Id = 1;
      p1.Name = "filtor de aceite k&n";
      p1.Description = "filtor de aceite k&n";
      p1.ImageURL = @"imagenes-autoparts\filtro-de-aceite-k&n.png";
      p1.Price = 95.00F;

      p2 = new Producto();
      p2.Id = 2;
      p2.Name = "Rin Mercedes Benz";
      p2.Description = "Rin Mercedes Benz - CLA-Class";
      p2.ImageURL = @"imagenes-autoparts\ring-mercedes-benz-cla-class.png";
      p2.Price = 165.00F;

      p3 = new Producto();
      p3.Id = 3;
      p3.Name = "Frenos de Disco";
      p3.Description = "Frenos de disco en color amarillo";
      p3.ImageURL = @"imagenes-autoparts\freno-de-disco-amarillo.png";
      p3.Price = 625.00F;

      p4 = new Producto();
      p4.Id = 4;
      p4.Name = "Timon Mazda";
      p4.Description = "Timon Mazda 2013";
      p4.ImageURL = @"imagenes-autoparts\timon-mazda-2013.png";
      p4.Price = 75.00F;

      // se gregan los productos
      productos.Add(p4);
      productos.Add(p3);
      productos.Add(p2);
      productos.Add(p1);

      // creo un grupo para listview llamado productos
      ListViewGroup productosGroup = new ListViewGroup("Productos", HorizontalAlignment.Center);

      // lista de imagenes
      ImageList listImagenes = new ImageList();
      // les doy unas dimenciones estandar de 100x100 pixeles
      listImagenes.ImageSize = new Size(100, 100);

      try
      {
        // contador que me sirve para controlar el indice de la imagen
        // dentro del listview, asi cada imagen pertenece a cada producto.
        int contador = 0;
        // recorro la lsita de los productos
        foreach (Producto prod in productos)
        {
          // creo el array statico con el nombre, descripcion y precio del producto
          string[] datosProd = new string[] { prod.Name, prod.Description, prod.Price.ToString() };

          // agrego el array 'datosProd' junto con el contador para asociar las imagenes
          // dentro del listview en el grupo de productos
          ltvProductos.Items.Add(new ListViewItem(datosProd, contador, productosGroup));

          // le doy la ruta de imagen para asociarla
          // con su respectivo producto
          listImagenes.Images.Add(Image.FromFile(prod.ImageURL));

          // aumento el contador
          contador++;

        } // --- foreach

        // agrego el listado de las imagenes para que sea impresas
        ltvProductos.SmallImageList = listImagenes;

      } // ----- try
      catch (Exception ex)
      {
        MessageBox.Show($"{ex.Message}");
      }// --- catch

     


    }

    private void btnRegresar_Click(object sender, EventArgs e)
    {
      //  creo el objeto de mi pantalla de login
      Autoparts au = Autoparts.GetInstanciaAutoparts();
      au.Show();

      // oculto el formuulario actual
      this.Hide();
    }
    // variable que me ayuda a totalizar el gasto
    double totalCompra = 0;
    private void btnAddCart_Click(object sender, EventArgs e)
    {

      try
      {
        // tomo los productos seleccionados
        // concretamente solo el primero, el unico seleccionado
        var items = ltvProductos.SelectedItems[0].SubItems;

        // creo una fila en el dataGridView
        int n = dgvCart.Rows.Add();
        
        // Recorro los datos que tenga el producto seleccionado
        for (int i = 0; i < items.Count; i++)
        {
          // lleno con los datos las celdas correspondientes
          // NOMBRE
          dgvCart.Rows[n].Cells[i].Value = items[i].Text;
          // DESCRIPCION
          dgvCart.Rows[n].Cells[i].Value = items[i].Text;

          // valido si es 2, porque se que el precio es el indice 2
          // esto me permite validar y convertir solo y solo si
          // es el precio, para que pueda hacer un parse del mismo,
          // ya que viene como texto, de esa forma le doy un formato
          // de divisa a cada valor de precio en la tabla
          if (i == 2)
          {
            double price = double.Parse(items[i].Text);
            // PRECIO
            dgvCart.Rows[n].Cells[i].Value = price;
            totalCompra += price;
          }

        }

        txtTotal.Text = $"$ {totalCompra.ToString()}";
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Debe de seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }

    private void PantallaVisitante_FormClosing(object sender, FormClosingEventArgs e)
    {
      // cuando cierran el formulario, me aseguro que se borre de memoria
      Application.Exit();
    }
  }
}
