using SmartList.ViewModels;

namespace SmartList.Services
{
    public interface INavigationService
    {
        void NavigateToPerson(PersonVM personVM);
    }
}