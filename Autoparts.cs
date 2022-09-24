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
  public partial class Autoparts : Form
  {

    /// <summary>
      //En una venta de partes de autos se necesitan atender al cliente y selecciones los
      //productos que necesita el cliente, se ingresa el tipo de producto como
      //amortiguadores, llantas, forros, entre otros, una vez elegidos los productos el
      //ejecutivo quien atiende ingresa el tipo de producto, cantidad y precio del producto,
      //para enviarlo a cancela a caja, por lo que necesita un sistema para ello, para esta
      //simulación puede hacerse dentro del mismo formulario.
    /// </summary>
    public Autoparts()
    {
      InitializeComponent();
    }

    // para verificar si exite la instancia o no
    // si existe, que retorne la misma, sino que la cree
    public static Autoparts _instanciaAutoparts;

    public static Autoparts GetInstanciaAutoparts()
    {
      if (_instanciaAutoparts == null)
      {
        _instanciaAutoparts = new Autoparts();
      }

      return _instanciaAutoparts;
    }


    private void Autoparts_Load(object sender, EventArgs e)
    {
      // color verde (152, 188, 80)

      // color gris (62, 64, 66);
    }

    private void linkVisitante_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

      // oculto este formulario, pero no lo cierro
      this.Hide();

      // muestro el formulario del usuario/cliente
      PantallaVisitante pv = PantallaVisitante.GetInstanciaPantallaVisitante();
      pv.Show();

    }

    private void btnSignin_Click(object sender, EventArgs e)
    {

    }

    private void Autoparts_FormClosing(object sender, FormClosingEventArgs e)
    {
      // cuando cierran el formulario, me aseguro que se borre de memoria
      Application.Exit();
    }
  }
}
