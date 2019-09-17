using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eXamarin.Data;
using System.IO;

namespace eXamarin
{
    public partial class App : Application
    {

        static NotesDatabase databaseNotes;
        static SubjectsDatabase databaseSubjects;
        static OrarioDatabase databaseOrario;

        public static NotesDatabase NoteDatabase
        {
            get
            {
                if (databaseNotes == null)
                {
                    databaseNotes = new NotesDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes2.db3"));
                }
                return databaseNotes;
            }
        }

        public static SubjectsDatabase SubjectsDatabase
        {
            get
            {
                if (databaseSubjects == null)
                {
                    databaseSubjects = new SubjectsDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "subjects.db3"));
                }
                return databaseSubjects;
            }
        }

        public static OrarioDatabase OrarioDatabase
        {
            get
            {
                if (databaseOrario == null)
                {
                    databaseOrario = new OrarioDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "orario.db3"));
                }
                return databaseOrario;
            }
        }

        public App()
        {
            InitializeComponent();
            //Utilizziamo LoginPage come prima pagina
            MainPage = new NavigationPage(new LoginPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
