using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACESS
{
    public interface IAvaliavel
    {
        string CalcularRecomendacaoIA();
        double CalcularProdutividade();
    }
    public abstract class Colaborador : IAvaliavel
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double IndiceFadiga { get; set; }

        public string StatusTexto => IndiceFadiga > 80 ? "CRÍTICO" : "NORMAL";

        public Colaborador(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
        public virtual double CalcularProdutividade()
        {
            return (100 - IndiceFadiga);
        }

        public abstract string CalcularRecomendacaoIA();
    }

    public class ColaboradorMotor : Colaborador
    {
        public bool UsaVoz { get; set; }

        public ColaboradorMotor(string n, int i, bool v)
            : base(n, i)
        {
            UsaVoz = v;
        }

        public override double CalcularProdutividade()
        {
            return base.CalcularProdutividade() * 1.2;
        }

        public override string CalcularRecomendacaoIA()
        {
            if (IndiceFadiga > 50)
                return "Sugestão IA: Ativar comandos de voz (Fadiga Muscular).";

            return "Sugestão IA: Manter controles de toque.";
        }
    }

    public class ColaboradorVisual : Colaborador
    {
        public int Zoom { get; set; }

        public ColaboradorVisual(string n, int i, int z)
            : base(n, i)
        {
            Zoom = z;
        }

        public override double CalcularProdutividade()
        {
            return base.CalcularProdutividade() * 1.1;
        }

        public override string CalcularRecomendacaoIA()
        {
            if (IndiceFadiga > 60)
                return "Sugestão IA: Ativar alto contraste (Fadiga Ocular).";

            return "Sugestão IA: Manter nível de zoom atual.";
        }
    }
}
