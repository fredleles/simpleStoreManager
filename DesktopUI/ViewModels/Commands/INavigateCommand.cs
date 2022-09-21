namespace DesktopUI.ViewModels.Commands
{
    internal interface INavigateCommand<T>
    {
        void Execute(object? parameter);
    }
}