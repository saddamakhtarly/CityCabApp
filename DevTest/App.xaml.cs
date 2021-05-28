using System;
using DevTest.ViewModels;
using DevTest.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevTest
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(StartPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<StartPage, StartPageViewModel>();
            containerRegistry.RegisterForNavigation<ForgotPasswordPage, ForgotPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<VerifyMobilePage, VerifyMobilePageViewModel>();
            containerRegistry.RegisterForNavigation<PaymentTypePage, PaymentTypePageViewModel>();
            containerRegistry.RegisterForNavigation<AddPaymentPage, AddPaymentPageViewModel>();
            containerRegistry.RegisterForNavigation<UpdatePhoneNumberPage, UpdatePhoneNumberPageViewModel>();
            containerRegistry.RegisterForNavigation<EditProfilePage, EditProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<ChangePaymentModePage, ChangePaymentModePageViewModel>();
            containerRegistry.RegisterForNavigation<BookingConfirmationPage, BookingConfirmationPageViewModel>();
            containerRegistry.RegisterForNavigation<FareEstimatePage, FareEstimatePageViewModel>();
            containerRegistry.RegisterForNavigation<NotificationPage, NotificationPageViewModel>();
            containerRegistry.RegisterForNavigation<HelpPage, HelpPageViewModel>();
            containerRegistry.RegisterForNavigation<PaymentPage, PaymentPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
            containerRegistry.RegisterForNavigation<EmergencyContactsPage, EmergencyContactsPageViewModel>();
            containerRegistry.RegisterForNavigation<EmergencyContactsListPage, EmergencyContactsListPageViewModel>();
            containerRegistry.RegisterForNavigation<ReviewYourTripPage, ReviewYourTripPageViewModel>();
            containerRegistry.RegisterForNavigation<HistoryPage, HistoryPageViewModel>();



        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
