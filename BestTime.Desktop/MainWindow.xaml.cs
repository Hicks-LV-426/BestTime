namespace BestTime.Desktop
{
  using System;
  using System.Linq;
  using System.Windows;
  using BestTime.Library;

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      try
      {
        var settings = new System.Configuration.AppSettingsReader();
        var activitiesFilePath = (string)settings.GetValue("filePath.activities", typeof(string));
        var unitOfMeasureFilePath = (string)settings.GetValue("filePath.unitsOfMeasure", typeof(string));
        var toDoItemsFilePath = (string)settings.GetValue("filePath.toDoItems", typeof(string));

        var reader = new Reader();
        var activitiesText = reader.GetText(activitiesFilePath);
        var unitsOfMeasureText = reader.GetText(unitOfMeasureFilePath);

        var serializer = new Serializer<Activity[]>();
        var activities = serializer.DeSerialize(activitiesText);

        var unitsSerializer = new Serializer<UnitOfMeasure[]>();
        var units = unitsSerializer.DeSerialize(unitsOfMeasureText);

        //activitiesTextBlock.Text = String.Join("\r\n", activities.Select(a => a.ToString()));
        activitiesTextBlock.Text = String.Join("\r\n", units.Select(u => u.ToString()));
      }
      catch (Exception ex)
      {
        activitiesTextBlock.Text = ex.Message;
      }
    }
  }
}
