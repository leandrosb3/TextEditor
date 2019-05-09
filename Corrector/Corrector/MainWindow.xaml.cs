using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;

namespace Corrector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string expression = @"[\.\?\!]\s+([a-z])";
        string input;
        string words;
        int cantidaddepalabras;
        int num;
        int tamaño;
        int acum;


        public MainWindow()
        {
            InitializeComponent();
            Editor.AcceptsReturn = true;
            Fuente.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            NumeroTamaño.ItemsSource = new List<double>() { 12, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            MessageBox.Show("Realizado por Leandro Santiago Batista Matricula 2015-0754 para la asignatura de algoritmos paralelos", "Atencion");
            NumeroTamaño.Text = "12";
           
           
              

         



        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
         {
            words = Editor.Text;
            input = words;
            int start = Editor.SelectionStart;
            int length = Editor.SelectionLength;
            cantidaddepalabras = words.Length;
            Letras.Text = Convert.ToString(cantidaddepalabras);
            if (Editor.Text.Length <= 0) return;
            string s = Editor.Text.Substring(0, 1);
            if(s != s.ToUpper())
            {
                int curSelStart = Editor.SelectionStart;
                int curSelLength = Editor.SelectionLength;
                Editor.SelectionStart = 0;
                Editor.SelectionLength = 1;
                Editor.SelectedText = s.ToUpper();
                Editor.SelectionStart = curSelStart;
                Editor.SelectionLength = curSelLength;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Char)KeyInterop.VirtualKeyFromKey(e.Key) == (Char)KeyInterop.VirtualKeyFromKey(Key.Enter) || (Char)KeyInterop.VirtualKeyFromKey(e.Key) == (Char)KeyInterop.VirtualKeyFromKey(Key.Space))
            {

                char[] charArray = input.ToCharArray();
                foreach (Match match in Regex.Matches(input, expression, RegexOptions.Singleline))

                {
                    charArray[match.Groups[1].Index] = Char.ToUpper(charArray[match.Groups[1].Index]);
                }
                string output = new string(charArray);
                Editor.Clear();
                Editor.Text = output;
                Editor.CaretIndex = Editor.Text.Length;
            }

           
        }

        private void AlinearDerecha_Click(object sender, RoutedEventArgs e)
        {
            Editor.TextAlignment = TextAlignment.Right;
        }
        private void AlinearIzquierda_Click(object sender, RoutedEventArgs e)
        {
            Editor.TextAlignment = TextAlignment.Left;
        }

        private void JustificarTexto_Click(object sender, RoutedEventArgs e)
        {
            Editor.TextAlignment = TextAlignment.Center;
        }

        private void NumeroTamaño_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelectionNumeroTamaño_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        

        }

        //Seccion para cambiar el tipo de letra con la cual se redactara el documento
        private void Fuente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Editor.FontFamily = new FontFamily(Convert.ToString(Fuente.Text));
        }

        // Funcion para guardar documento
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            //Funcion para guardar archivos
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
                File.WriteAllText(saveFileDialog.FileName, Editor.Text);

            }
        }

        //Funcion para abrir un nuevo archivo
        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            var Nuevo = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> Success = Nuevo.ShowDialog();
            Nuevo.DefaultExt = ".txt";
            Nuevo.Filter = "Text documents (.txt)|*.txt";
            if (Success.HasValue && Success.Value)
            {

                Editor.Text = System.IO.File.ReadAllText(Nuevo.FileName);
            }
            else
            {
                //No se pudo abrir el archivo
            }

        }

        //Funcion para poder imprimir el documento escrito
        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult imprimir = MessageBox.Show("Desea imprimir el texto?, si no, se imprimira la aplicación", "Impresión", MessageBoxButton.YesNoCancel);
            PrintDialog dialog = new PrintDialog();
            if (imprimir == MessageBoxResult.Yes)

            {
                // Imprimir el texto

                if (dialog.ShowDialog() == true)

                {

                    String texto = Editor.Text;

                    Run r = new Run(texto);

                    Paragraph parrafo = new Paragraph();

                    parrafo.Inlines.Add(r);

                    FlowDocument documento = new FlowDocument(parrafo);

                    documento.PagePadding = new Thickness(100);

                    dialog.PrintDocument(((IDocumentPaginatorSource)documento).DocumentPaginator, texto);

                }

            }
            else if (imprimir == MessageBoxResult.No)

            {

                // Imprimir la pantalla

                if (dialog.ShowDialog() == true)

                {

                    dialog.PrintVisual(this, "Impresión");

                }

            }
        }
        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult nuevodocumento = MessageBox.Show("Desea crear un nuevo Documento. Esto eliminara el progreso actual", "Atencion", MessageBoxButton.YesNo);
            if (nuevodocumento == MessageBoxResult.Yes)
                Editor.Clear();
        }

        private void NumeroTamaño_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
         
        }

        private void tLetra_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void NumeroTamaño_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {

        }

        private void NumeroTamaño_ManipulationCompleted_1(object sender, ManipulationCompletedEventArgs e)
        {
          
        }

        private void NumeroTamaño_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
           
        }

        private void NumeroTamaño_MouseEnter(object sender, MouseEventArgs e)
        {
          
        }

        //Modifica el tamaño de la fuente seleciconada 
        private void NumeroTamaño_MouseLeave(object sender, MouseEventArgs e)
        {
            Editor.FontSize = int.Parse(NumeroTamaño.Text);
        }
    }
}



