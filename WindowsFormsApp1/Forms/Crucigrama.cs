using crucigramaForm.Entidades;
using crucigramaForm.Persistencia;
using CrucigramaForms.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace crucigramaForm
{
    public partial class Main : Form
    {

        Pistas p_ventana = new Pistas();
        Puntajes pun_ventana = new Puntajes();
        List<id_celdas> idc = new List<id_celdas>();
        public String archivo_p = Application.StartupPath + "\\Crucigramas\\puzzle1.tp4";
        public Main()
        {
            crearListaPalabra();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarPizarra();
            p_ventana.SetDesktopLocation(Location.X + Width + 1, Location.Y);
            p_ventana.StartPosition = FormStartPosition.Manual;

            p_ventana.Show();
            p_ventana.tabla_pistas.AutoResizeColumns();

            InicializarPuntaje();
            pun_ventana.SetDesktopLocation(Location.X + Width - Width - 400, Location.Y);
            pun_ventana.StartPosition = FormStartPosition.Manual;
            pun_ventana.Show();
        }


        private void InicializarPuntaje() //setea el gridview a negro
        {
            Pizarra.BackgroundColor = Color.Black;
            Pizarra.DefaultCellStyle.BackColor = Color.Black;

        }

        private void InicializarPizarra() 
        {
            Pizarra.BackgroundColor = Color.Black;
            Pizarra.DefaultCellStyle.BackColor = Color.Black;

            for (int i = 0; i < 21; i++)
                Pizarra.Rows.Add();

            
            foreach (DataGridViewColumn c in Pizarra.Columns) //seteamos ancho de cada columna
                c.Width = Pizarra.Width / Pizarra.Columns.Count;
            
            foreach (DataGridViewRow r in Pizarra.Rows) //seteamos ancho de cada celda
                r.Height = Pizarra.Height / Pizarra.Rows.Count;

            
            for (int colum = 0; colum < Pizarra.Rows.Count; colum++) //seteamos todas celdas read only
            {
                for (int col = 0; col < Pizarra.Columns.Count; col++)
                    Pizarra[col, colum].ReadOnly = true;
            }

            foreach (id_celdas i in idc) //recorre las palabras del archivo .tp4 y las separa por caracteres
            {
                int col_inicio = i.X;
                int fila_inicio = i.Y;
                char[] palabra = i.palabra.ToCharArray();

                for (int j = 0; j < palabra.Length; j++) //iterando en cada palabra para ver cuantos cuadros crear
                {
                    if (i.direccion.ToUpper() == "HORIZONTAL")
                        formatoCelda(fila_inicio, col_inicio + j, palabra[j].ToString());
                    if (i.direccion.ToUpper() == "VERTICAL")
                        formatoCelda(fila_inicio + j, col_inicio, palabra[j].ToString());
                }

            }

        }

        private void formatoCelda(int cel, int col, string letra)
        {
            DataGridViewCell c = Pizarra[col, cel];
            c.Style.BackColor = Color.White;
            c.ReadOnly = false;
            c.Style.SelectionBackColor = Color.Green;
            c.Tag = letra;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Pizarra[e.ColumnIndex, e.RowIndex].Value = Pizarra[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper(); //hacemos las letras mayusculas
            }
            catch { }

            try
            {
                if (Pizarra[e.ColumnIndex, e.RowIndex].Value.ToString().Length > 1)
                    Pizarra[e.ColumnIndex, e.RowIndex].Value = Pizarra[e.ColumnIndex, e.RowIndex].Value.ToString().Substring(0, 1); //truncar a una letra, por si se
                                                                                                                                    //manda mas de un caracter
            }
            catch { }

            try
            {
                if
                    (Pizarra[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper().Equals(Pizarra[e.ColumnIndex, e.RowIndex].Tag.ToString().ToUpper()))
                {
                    Pizarra[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkGreen;   //verificar si la palabra es la correcta
                }
                else
                {
                    Pizarra[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red; 
                }
            }
            catch { }

        }

        private void abrirCrucigramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Archivos Crucigrama|*.tp4"
            };
            if (ofd.ShowDialog().Equals(DialogResult.OK)) //para reemplazar el archivo actual
            {
                Pizarra.Rows.Clear();
                p_ventana.tabla_pistas.Rows.Clear();
                idc.Clear();

                archivo_p = ofd.FileName;

                crearListaPalabra();
                InicializarPizarra();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearListaPalabra() //lee el archivo .tp4
        {
            string linea = "";
            using (StreamReader s = new StreamReader(archivo_p))
            {
                linea = s.ReadLine(); //ignora la 1era linea
                while ((linea = s.ReadLine()) != null)
                {
                    string[] l = linea.Split('|');
                    idc.Add(new id_celdas(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], l[3], l[4], l[5])); //crea las celdas del conjunto solucion
                    p_ventana.tabla_pistas.Rows.Add(new string[] { l[3], l[2], l[5] }); //añade las pistas a al tabla pistas
                }


            }

        }

        private void sobreNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ernst ELwin, Valenzuela Sebastián, Hein Ian", "NullPointerException");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_LocationChanged(object sender, EventArgs e) //esto hace que las ventanas se muevan juntas
        {
            p_ventana.SetDesktopLocation(Location.X + Width + 10, Location.Y);
            pun_ventana.SetDesktopLocation(Location.X + Width - Width - 400, Location.Y);
        }

        private void Pizarra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string number = "";

            if (idc.Any(c => (number = c.numero) != "" && c.X == e.ColumnIndex && c.Y == e.RowIndex))
            {
                //Create solid brush to fill cell
                SolidBrush selectedcolor = new SolidBrush(Color.White);
                //Create brush from GridColor 
                Brush gridBrush = new SolidBrush(Pizarra.GridColor);
                //Create pen from GridColor brush
                Pen gridLinePen = new Pen(gridBrush);
                //Create new rectangle the size of the cell
                Rectangle r = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                //Check 2 conditions 
                //First condition is the cell selected
                //Second condition is the cell being edited 
                //this will paint the SelectionBackColor only if the cell is selected and not being edited 
                if (Pizarra[e.ColumnIndex, e.RowIndex].Selected == true && Pizarra[e.ColumnIndex, e.RowIndex].IsInEditMode == false)
                    selectedcolor = new SolidBrush(e.CellStyle.SelectionBackColor);
                else
                    selectedcolor = new SolidBrush(Color.White);
                //Draw a filled rectangle of the selected color 
                e.Graphics.FillRectangle(selectedcolor, r);
                //Redraw the cell border 
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                //Draw the cell superscript number 
                Font f = new Font(e.CellStyle.Font.FontFamily, 7);
                e.Graphics.DrawString(number, f, Brushes.Black, r);
                //Clean up after our self's 
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Pizarra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ganar();
        }
        public void ganar()
        {
            bool winner = true;

            for (int fila = 0; fila < Pizarra.Rows.Count; fila++)
            {
                for (int col = 0; col < Pizarra.Rows.Count; col++)
                {
                    if ((Pizarra[col, fila].Style.ForeColor != Color.DarkGreen) && (Pizarra[col, fila].Style.BackColor == Color.White))
                    {
                        winner = false;
                    }
                }
            }
            if (winner)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Completaste el Crucigrama!!", "Felicidades");
                Usuario u = pUsuario.GetUsuarioByUser(Program.user);
                u.Puntos += 10;
                pUsuario.Update(u);

            }



        }



        public class id_celdas
        {
            public int X;
            public int Y;
            public String direccion;
            public String numero;
            public String palabra;
            public String pista;

            public id_celdas(int x, int y, String d, String n, String p, String pi)
            {
                this.X = x;
                this.Y = y;
                this.direccion = d;
                this.numero = n;
                this.palabra = p;
                this.pista = pi;
            }
        }
    }
}
