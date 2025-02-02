using System.Drawing;

namespace aff
{
    public static class Program
    {

        public static void Main()
        {
            Console.WriteLine("Un programme pour trouver a et b du fonction y = ax  + b avec la methode de descente de gradiant:\n");
            //intialisation des donnees
            List<PointF> les_points = Fonction.getData();
            PointF random_point = new PointF(0.4f, 0.2f);
            int nombre_iteration = 10;
            float avancement_alpha = 0.01f;
            PointF resp_point = new PointF(1, 2);
            //sortie des donnees
            display(random_point, les_points, nombre_iteration, avancement_alpha, resp_point);
        }

        public static void display(PointF random_point, List<PointF> les_points, int nombre_iteration, float avancement_alpha, PointF resp_point)
        {
            Console.WriteLine("Sur les points  " + string.Join(";", les_points));
            Console.WriteLine("A " + nombre_iteration + " iteration");
            Console.WriteLine(avancement_alpha + " comme avancement");
            Console.WriteLine("On trouve " + resp_point);
            float x = resp_point.X;
            float y = resp_point.Y;
            Console.WriteLine("D'ou y= " +"x" + x   + " + "  + y );
            Console.WriteLine("\n");

        }
        static void openFenetre()
        {
            Application.Run(new Fenetre());
        }
    }

};

