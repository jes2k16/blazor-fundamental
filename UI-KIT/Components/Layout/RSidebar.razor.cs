
using Microsoft.JSInterop;
namespace UI_KIT.Components.Layout;

public partial class RSidebar
{
    public bool IsSidebarOpen = true;
    public bool IsBackdropVisible = false;

    public List<WatchlistSection> WatchlistSections = new List<WatchlistSection>
        {
            new WatchlistSection 
            { 
                Title = "LOW RISK - 300 PIPS - 40% RETRACE",
                Items = new List<WatchlistItem>
                {
                    new WatchlistItem { Symbol = "AUDCAD", Last = "0.91041", Change = "-0.00061", ChangePercent = "-0.07%", IsNegative = true, Flag = "🇦🇺" },
                    new WatchlistItem { Symbol = "AUDNZD", Last = "1.13309", Change = "-0.00040", ChangePercent = "-0.04%", IsNegative = true, Flag = "🇦🇺" },
                    new WatchlistItem { Symbol = "AUDUSD", Last = "0.65249", Change = "-0.00152", ChangePercent = "-0.23%", IsNegative = true, Flag = "🇦🇺" }
                }
            },
            new WatchlistSection 
            { 
                Title = "MID RISK - 500 PIPS - 50% RETRACE",
                Items = new List<WatchlistItem>
                {
                    new WatchlistItem { Symbol = "AUDCHF", Last = "0.55206", Change = "-0.00007", ChangePercent = "-0.01%", IsNegative = true, Flag = "🇦🇺" },
                    new WatchlistItem { Symbol = "CADCHF", Last = "0.57539", Change = "-0.00034", ChangePercent = "-0.06%", IsNegative = true, Flag = "🇨🇦" },
                    new WatchlistItem { Symbol = "GBPCAD", Last = "1.85262", Change = "0.00095", ChangePercent = "0.21%", IsNegative = false, Flag = "🇬🇧" },
                    new WatchlistItem { Symbol = "EURCAD", Last = "1.51759", Change = "-0.00030", ChangePercent = "-0.02%", IsNegative = true, Flag = "🇪🇺" }
                }
            },
            new WatchlistSection 
            { 
                Title = "HIGH RISK - 1000 PIPS - 30% RETRACE",
                Items = new List<WatchlistItem>
                {
                    new WatchlistItem { Symbol = "CHFJPY", Last = "187.259", Change = "-0.014", ChangePercent = "-0.01%", IsNegative = true, Flag = "🇨🇭" },
                    new WatchlistItem { Symbol = "EURAUD", Last = "1.78003", Change = "0.00492", ChangePercent = "0.28%", IsNegative = false, Flag = "🇪🇺" },
                    new WatchlistItem { Symbol = "EURGBP", Last = "0.82401", Change = "0.00575", ChangePercent = "0.28%", IsNegative = false, Flag = "🇪🇺" }
                }
            },
            new WatchlistSection 
            { 
                Title = "CRYPTO",
                Items = new List<WatchlistItem>
                {
                    new WatchlistItem { Symbol = "BTCUSD", Last = "108,795", Change = "-226", ChangePercent = "-0.21%", IsNegative = true, Flag = "₿" },
                    new WatchlistItem { Symbol = "ETHUSD", Last = "3,885.0", Change = "10.4", ChangePercent = "0.27%", IsNegative = false, Flag = "Ξ" },
                    new WatchlistItem { Symbol = "XRPUSD", Last = "2.70325", Change = "-0.04138", ChangePercent = "-1.51%", IsNegative = true, Flag = "◆" }
                }
            }
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

    public class WatchlistSection
    {
        public string Title { get; set; } = string.Empty;
        public List<WatchlistItem> Items { get; set; } = new List<WatchlistItem>();
    }

    public class WatchlistItem
    {
        public string Symbol { get; set; } = string.Empty;
        public string Last { get; set; } = string.Empty;
        public string Change { get; set; } = string.Empty;
        public string ChangePercent { get; set; } = string.Empty;
        public bool IsNegative { get; set; }
        public string Flag { get; set; } = string.Empty;
    }
}
