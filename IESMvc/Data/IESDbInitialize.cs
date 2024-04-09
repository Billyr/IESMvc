using IESMvc.Models;

namespace IESMvc.Data
{
    public static class IESDbInitialize
    {
        public static void Initialize(IESContext context)
        {

            context.Database.EnsureCreated();
            
            if (context.Departamentos.Any())
            {
                return;
            }
            
            var departamentos = new Departamento[]
            {
                new Departamento { Nombre="Computer Science"},
                new Departamento { Nombre="Food Science"}
            };

            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();
        }
    }
}
