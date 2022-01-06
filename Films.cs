namespace CSh_Lab_12
{
    class Films
    {
        //Поля
        private string name;
        private string director;
        private int releaseDate;

        //Свойства
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Director
        {
            get
            {
                return this.director;
            }
            set
            {
                this.director = value;
            }
        }
        public int ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }

        //Конструкторы
        public Films(string name, string director, int releaseDate)
        {
            Name = name;
            Director = director;
            ReleaseDate = releaseDate;
        }
        public Films(string name, int LifeTime)
        {
            Name = name;
            ReleaseDate = LifeTime;
        }
        public override string ToString()
        {
            string f = Name + ',' + Director + ',' + ReleaseDate;
            return f;
        }
    }
}
