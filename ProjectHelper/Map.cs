namespace ProjectHelper
{
    public class Map<TObject> where TObject : SimpleIndexable
    {
        public Dictionary<string, TObject> Itens { get; }

        public Map()
        {
            Itens = new Dictionary<string, TObject>();
        }

        public TObject Get(string id)
        {
            return Itens[id];
        }

        public void Add(TObject o)
        {
            Itens.Add(o.Id, o);
        }

        public bool Has(string id)
        {
            return Itens.ContainsKey(id);
        }
    }
}