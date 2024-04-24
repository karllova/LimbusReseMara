using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LimbusReseMara;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int TotalPoint { get; set; }
    public Dictionary<string, int> stats;
    private Dict dict = new Dict();
    public int EgoNum = 0;

    public MainWindow()
    {
        InitializeComponent();
        TotalPoint = 0;
        stats = new Dictionary<string, int>();
        stats.Add("zeroTiers", 0);
        stats.Add("point5Tiers", 0);
        stats.Add("ThreeStars", 0);
        stats.Add("TwoStars", 0);
    }

    public int GetTotalPoint()
    {
        return TotalPoint;
    }

    private void Box_Checked(object sender, RoutedEventArgs e)
    {
        CheckBox C = (CheckBox)sender;
        string content = C.Content.ToString();
        TotalPoint += dict.GetValue(content)[0];
        if (dict.GetValue(content)[0] == 50)
        {
            stats["zeroTiers"]++;
        }

        if (dict.GetValue(content)[0] == 40)
        {
            stats["point5Tiers"]++;
        }

        if (dict.GetValue(content)[1] == 3)
        {
            stats["ThreeStars"]++;
        }
        else
        {
            stats["TwoStars"]++;
        }
    }

    private void Box_Unchecked(object sender, RoutedEventArgs e)
    {
        CheckBox C = (CheckBox)sender;
        string content = C.Content.ToString();
        TotalPoint -= dict.GetValue(content)[0];
        if (dict.GetValue(content)[0] == 50)
        {
            stats["zeroTiers"]--;
        }

        if (dict.GetValue(content)[0] == 40)
        {
            stats["point5Tiers"]--;
        }

        if (dict.GetValue(content)[1] == 3)
        {
            stats["ThreeStars"]--;
        }
        else
        {
            stats["TwoStars"]--;
        }
    }

    private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
    {
        EgoNum = int.Parse(Egos.Text) * 5;
        TotalPoint = TotalPoint + EgoNum;
        Window result = new Result();
        result.Show();
    }

    private void ResetButton_OnClick(object sender, RoutedEventArgs e)
    {
        UncheckAllCheckBoxes(this);
        TotalPoint = 0;
        foreach (var keys in stats.Keys)
        {
            stats[keys] = 0;
        }

        Egos.Text = "0";
    }

    private void UncheckAllCheckBoxes(DependencyObject obj)
    {
        // ScrollViewer 안에 있는 모든 StackPanel을 찾습니다.
        foreach (var child in FindVisualChildren<StackPanel>(obj))
        {
            // StackPanel 내의 모든 CheckBox를 찾습니다.
            foreach (var checkBox in FindVisualChildren<CheckBox>(child))
            {
                // CheckBox를 해제합니다.
                checkBox.IsChecked = false;
            }
        }
    }

    private IEnumerable<T> FindVisualChildren<T>(DependencyObject obj) where T : DependencyObject
    {
        if (obj != null)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                {
                    yield return (T)child;
                }

                foreach (T childOfChild in FindVisualChildren<T>(child))
                {
                    yield return childOfChild;
                }
            }
        }
    }

    private void ClipB_OnClick(object sender, RoutedEventArgs e)
    {
        Clipboard.SetText("LimbusCompany");
    }
}