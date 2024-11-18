namespace ConsultaFacturaImagen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Validar que se haya pasado un argumento
            if (args.Length > 0)
            {
                string numeroFactura = args[0];
                Application.Run(new Form1(numeroFactura));
            }
            else
            {
                MessageBox.Show("Debe proporcionar el número de factura como argumento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}