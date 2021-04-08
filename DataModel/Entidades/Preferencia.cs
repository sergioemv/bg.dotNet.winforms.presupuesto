namespace DataModel.Entidades
{
    
    public class Preferencia
    {
        private string key;
        private string value;
        public Preferencia()
        {
        }

        public Preferencia(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public virtual string Key
        {
            get { return key; }
            set { key = value; }
        }

        public virtual string Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}