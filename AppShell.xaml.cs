namespace aperezs6B
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            MainPage = new NavigationPage(new vEstudiante());
        }
    }
}
