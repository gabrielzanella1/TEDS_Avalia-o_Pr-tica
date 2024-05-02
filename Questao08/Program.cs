Ingles cursoIngles = new Ingles("Intensivo Inglês", "Concluido", "Avançado", 85);
cursoIngles.AdicionaNota(6.3);
cursoIngles.AdicionaNota(6.6);
cursoIngles.AdicionaNota(6.9);

cursoIngles.ConsultarPresenca();
Console.WriteLine($"Média das notas: {cursoIngles.CalcularMediaNota()}");
cursoIngles.EmitirCertificado();
Console.WriteLine();

Frances cursoFrances = new Frances("Básico Francês", "Concluido", "Básico", 75);
cursoFrances.ConsultarPresenca();
cursoFrances.EmitirCertificado();
Console.WriteLine();

Espanhol cursoEspanhol = new Espanhol("Intermediário Espanhol", "Cursando", "Intermediário", 75);
cursoEspanhol.ConsultarPresenca();
cursoEspanhol.EmitirCertificado();


