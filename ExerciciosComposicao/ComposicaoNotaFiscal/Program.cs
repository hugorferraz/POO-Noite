using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(13);
ItemNotaFiscal it2 = new ItemNotaFiscal(27);
List<ItemNotaFiscal> vetI = new List<ItemNotaFiscal>();
vetI.Add(it1);
vetI.Add(it2);
NotaFiscal nf = new NotaFiscal(1,"28/09/2026",vetI);
nf.Mostrar();
nf = null; //retira a referência da instância
GC.Collect(); //força a chamada do coletor de lixo