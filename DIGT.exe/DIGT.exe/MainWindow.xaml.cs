using System;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Windows.ApplicationModel;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DIGT.exe
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow m_AppWindow;

        public MainWindow()
        {
            this.InitializeComponent();
            this.AppWindow.Resize(new Windows.Graphics.SizeInt32(550, 1010));

            m_AppWindow = GetAppWindowForCurrentWindow();
            var titleBar = m_AppWindow.TitleBar;
            // Hide system title bar.
            titleBar.ExtendsContentIntoTitleBar = true;
        }

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(wndId);
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch1.IsOn = true;
            ToggleSwitch2.IsOn = true;
            ToggleSwitch3.IsOn = true;
            ToggleSwitch4.IsOn = true;
            ToggleSwitch5.IsOn = true;
            ToggleSwitch6.IsOn = true;
            ToggleSwitch7.IsOn = true;
            ToggleSwitch8.IsOn = true;
            ToggleSwitch9.IsOn = true;
            ToggleSwitch10.IsOn = true;
            ToggleSwitch11.IsOn = true;
            ToggleSwitch12.IsOn = true;
            ToggleSwitch13.IsOn = true;
            ToggleSwitch14.IsOn = true;
            ToggleSwitch15.IsOn = true;
            ToggleSwitch16.IsOn = true;
            ToggleSwitch17.IsOn = true;
            ToggleSwitch18.IsOn = true;
            ToggleSwitch19.IsOn = true;
            ToggleSwitch20.IsOn = true;
            ToggleSwitch21.IsOn = true;
            ToggleSwitch22.IsOn = true;
        }

        private void DeselectAll_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch1.IsOn = false;
            ToggleSwitch2.IsOn = false;
            ToggleSwitch3.IsOn = false;
            ToggleSwitch4.IsOn = false;
            ToggleSwitch5.IsOn = false;
            ToggleSwitch6.IsOn = false;
            ToggleSwitch7.IsOn = false;
            ToggleSwitch8.IsOn = false;
            ToggleSwitch9.IsOn = false;
            ToggleSwitch10.IsOn = false;
            ToggleSwitch11.IsOn = false;
            ToggleSwitch12.IsOn = false;
            ToggleSwitch13.IsOn = false;
            ToggleSwitch14.IsOn = false;
            ToggleSwitch15.IsOn = false;
            ToggleSwitch16.IsOn = false;
            ToggleSwitch17.IsOn = false;
            ToggleSwitch18.IsOn = false;
            ToggleSwitch19.IsOn = false;
            ToggleSwitch20.IsOn = false;
            ToggleSwitch21.IsOn = false;
            ToggleSwitch22.IsOn = false;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            // Add any logic you need to handle before closing the window
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Add any logic you need to handle before closing the window
            this.Close();
        }
    }
}
