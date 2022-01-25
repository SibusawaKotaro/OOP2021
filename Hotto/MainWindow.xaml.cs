using System.Net;
using System.Net.Http;
using System.Windows;

namespace Hotto {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void Hotto() {
            using (var client = new HttpClient()) {

                using (WebClient webClient = new WebClient()) {
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    string str = webClient.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=975b01c0f41d3986&lat=33.590543&lng=130.420096&range=2&order=1&format=json");

                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }
    }
}
