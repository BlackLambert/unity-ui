using System.Threading.Tasks;
using UnityEngine;

namespace SBaier.UI
{
    public abstract class Displayer : MonoBehaviour
    {
        public abstract Task Show(bool immediately);
        public abstract Task Hide(bool immediately);
    }
}
