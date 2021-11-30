using System;

using System.Linq;


namespace Session09_02_WApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            QLSINHVIENEntities db = new QLSINHVIENEntities();

            var list = from sv in db.SinhViens select sv;
            IQueryable<SinhVien> listSV = from sv in db.SinhViens select sv;

            foreach (var item in list)
            {
                Console.WriteLine("{0,5} | {1,-10} | {2,-10}",
                    item.MaSV, item.HoSV, item.TenSV);
            }


            Console.ReadLine();
        }
    }
}
