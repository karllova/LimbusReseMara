using System.Windows;

namespace LimbusReseMara;

public partial class Result : Window
{
    public Result()
    {
        InitializeComponent();
        int totalpoint = ((MainWindow)Application.Current.MainWindow).GetTotalPoint();
        this.TotalPointText.Text = totalpoint.ToString();
        this.Comment.Text = comments(totalpoint);
        var stats = ((MainWindow)Application.Current.MainWindow).stats;
        this.zeroTiers.Text = stats["zeroTiers"].ToString();
        this.point5Tiers.Text = stats["point5Tiers"].ToString();
        this.ThreeStars.Text = stats["ThreeStars"].ToString();
        this.TwoStars.Text = stats["TwoStars"].ToString();
        this.egos.Text = (((MainWindow)Application.Current.MainWindow).EgoNum/5).ToString();
    }
    private string comments(int point)
    {
        if (point>120)
        {
            return "무조건 이륙";
        }
        if (point>=100)
        {
            return "이륙 가능 점수";
        }
        if (point>=80)
        {
            return "0.5티어 인격 존재 시, 이륙 가능";
        }
        if (point>=70)
        {
            return "0티어 인격 존재 시, 이륙 가능.";
        }

        if (point>=50)
        {
            return "이륙불가";
        }
        if (point>=40)
        {
            return "진심?";
        }

        return "썩은내상어";
    }
    
}