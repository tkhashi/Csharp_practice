using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater {
    public class Letter {
        protected Random random;
        public Letter(Random random) {
            this.random = random;
        }
        public virtual string GetLetter() {
            return string.Empty;
        }
    }
}
