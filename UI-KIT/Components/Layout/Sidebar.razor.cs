using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Notifications;

namespace UI_KIT.Components.Layout
{

    public partial class Sidebar
    {
        public SfToast? ToastInfo;
        public SfToast? ToastWarning;
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Field = "Home", FontIcon = "e-icons e-home", Route = "/" },
            new MenuItem { Field = "Lead Management", FontIcon = "e-icons e-grid-view", Route = "/customers" },
            new MenuItem { Field = "Notifications", FontIcon = "sf-icon-notification-bell-01", Route = "/notifications" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 640;
            }
            StateHasChanged();
        }

        public class MenuItem
        {
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
            public string Route { get; set; } = string.Empty;
        }
    }

}
