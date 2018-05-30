using System.ComponentModel;
namespace GameEngine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public int MaximumHitPoints { get; set; }

        private int _currentHitPoints;
        public int CurrentHitPoints
        {
            get
            {
                return _currentHitPoints;
            }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
