using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppingCart.Services
{
    public class NavigationService : INavigationService
    {
        public INavigation Navi { get; internal set; }
        public Page myPage { get; set; }

        public void InsertPageBefore(Page page, Page before)
        {
            Navi.InsertPageBefore(page, before);
        }

        public Task<Page> PopAsync()
        {
            return Navi.PopAsync();
        }

        public Task<Page> PopAsync(bool animated)
        {
            return Navi.PopAsync(animated);
        }

        public Task<Page> PopModalAsync()
        {
            return Navi.PopModalAsync();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            return Navi.PopModalAsync(animated);
        }

        public Task PopToRootAsync()
        {
            return Navi.PopToRootAsync();
        }

        public Task PopToRootAsync(bool animated)
        {
            return Navi.PopToRootAsync(animated);
        }

        public Task PushAsync(Page page)
        {
            return Navi.PushAsync(page);
        }

        public Task PushAsync(Page page, bool animated)
        {
            return Navi.PushAsync(page, animated);
        }

        public Task PushModalAsync(Page page)
        {
            return Navi.PushModalAsync(page);
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            return Navi.PushModalAsync(page, animated);
        }

        public void RemovePage(Page page)
        {
            Navi.RemovePage(page);
        }

        public IReadOnlyList<Page> ModalStack
        {
            get { return Navi.ModalStack; }
        }

        public IReadOnlyList<Page> NavigationStack
        {
            get { return Navi.NavigationStack; }
        }

        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel = null)
        {
            return myPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}