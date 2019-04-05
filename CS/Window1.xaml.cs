using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Bars;

namespace WpfApplication8 {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 100; i++) {
                list.Add(new TestData() {
                    Number1 = i,
                    Number2 = i * 10,
                    Text1 = "row " + i,
                    Text2 = "ROW " + i
                });
            }

            DataContext = list;
        }

        #region #Add

        private void BarCheckItem_CheckedChanged(object sender, ItemClickEventArgs e) {
            // do something...
        }

        private void BarButtonItem_ItemClick(object sender, ItemClickEventArgs e) {
            // do something...
        }
        #endregion #Add
    }

    public class TestData {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
    }

}
