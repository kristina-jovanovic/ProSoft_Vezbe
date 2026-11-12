using Domain;

namespace SistemskeOperacije
{
    public class IzmeniGradSO : ApstraktnaSO
    {
        private Grad grad;
        public IzmeniGradSO(Grad g)
        {
            grad = g;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            //broker.IzmeniGrad(grad);
        }
    }
}
