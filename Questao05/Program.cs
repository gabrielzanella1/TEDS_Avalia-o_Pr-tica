//---------> Exemplo Prático

Filme filme1 = new Filme("Piratas do Caribe", "Aventura", 2, true);
filme1.Locar();
filme1.Verificar();
filme1.Devolver();
Console.WriteLine();

//-----------------------------------------------------

Filme filme2 = new Filme("Interestelar", "Ficção Científica", 3, false);
filme2.Verificar();
filme2.Devolver();
filme2.Locar();
Console.WriteLine();
