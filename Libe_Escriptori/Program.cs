using Libe_Escriptori.Forms.Courses;
using Libe_Escriptori.Forms.Centres;


namespace Libe_Escriptori
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.Courses.FormCourses1());
            //Application.Run(new Forms.Gestionar_Usuaris.Professors.GestionarUsuarisProfessorsAfegint());
            //Application.Run(new Forms.Gestionar_Usuaris.GestionarUsuarisAlumnesAfegint());


        }
    }
}