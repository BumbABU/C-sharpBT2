using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARPBT2.OOP
{
    internal class Hinhchunhat
    {
        private float d;
        private float r;
        private MyDate ngaytao;

        //default hcn
        public Hinhchunhat( )
        {
            this.d = 0.0f;
            this.r = 0.0f;
            
        }

      
        public Hinhchunhat(float d, float r,MyDate ngaytao)
        {
            this.d = d;
            this.r = r;
            this.ngaytao = ngaytao;
        }

        public Hinhchunhat(float d, float r)
        {
            this.d = d;
            this.r = r;
        
        }

        public float D
        {
            set { this.d = value; }
            get { return this.d; }
        }

        public float R
        {
            set { this.r = value; }
            get { return this.r; }
        }
            //ham thanh phan tinh dien tich
        public string tinhdientich()
        {
            float s = d * r;
            return "S  = " + s;
        }

        public float tinhdientich2()
        {
            float s = d * r;
            return s;
        }
        public override string? ToString()
        {
            float dt = d * r;
            return "dt : " + dt + "created : " + ngaytao;
        }

     //Tạo constructor dạng đối tượng 
        public Hinhchunhat(Hinhchunhat hcn) {
            this.d = hcn.d;
            this.r = hcn.r;
        }

        // Viết hàm mà gọi nó thì biết chiều dài và chiều rộng
        public static Hinhchunhat Enter1hcn()
        {
            Console.WriteLine("Nhap chieu dai hcn");
            string cd = Console.ReadLine();
            float d = (float)Convert.ToDouble(cd);
            Console.WriteLine("Nhap chieu rong hcn");
            string chieur = Console.ReadLine();
            float r = (float)Convert.ToDouble(chieur);

            DateTime now = DateTime.Now;
            MyDate nt = new MyDate(now.Day,now.Month, now.Year);
            return new Hinhchunhat(d, r,nt);
        }

        public static void nhapNHCN(Hinhchunhat[] d,int soluong)
        {

          
            for (int i =0;i<soluong ;i++)
            {

                /* Hinhchunhat HCN = Enter1hcn();
                   d[i] = HCN;*/
                d[i]= Enter1hcn();
                 
            }
        }

        public static void xuatNHCN(Hinhchunhat[] m) { 
            for(int i =0;i<m.Length ;i++)
            {
                Console.WriteLine(m[i]);
            }
        }

        public static void maxHCN(Hinhchunhat[] m)
        {
            float max = m[0].tinhdientich2();
            for (int i = 0;i<m.Length;i++)
            {
                if (max < m[i].tinhdientich2())
                {
                    max = m[i].tinhdientich2();
                }
            }
            Console.WriteLine("Max : " + max);
        } 
     
    }
}
