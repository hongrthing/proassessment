  
using System; 
//일반적으로 사용되는 값과 참조 데이터 형식, 이벤트와 이벤트 처리기, 인터페이스, 특성, 예외 처리 등을 정의하는 핵심 클래스 및 기본 클래스가 포함되어 있습니다.
using System.Collections.Generic;
//제네릭 컬렉션을 정의하는 클래스와 인터페이스가 포함되어 있습니다. 이를 통해 사용자는 제네릭이 아닌 강력한 형식의 컬렉션보다 형식 안전성과 성능이 높은 강력한 형식의 컬렉션을 만들 수 있습니다.
using System.ComponentModel;
//구성 요소와 컨트롤의 런타임 및 디자인 타임 동작을 구현하는 데 사용되는 클래스를 제공합니다. 이 네임스페이스에는 특성 및 형식 변환기를 구현하고, 데이터 소스에 바인딩하고, 구성 요소 사용을 허가하기 위한 기본 클래스 및 인터페이스가 포함됩니다.
using System.Data;
//ADO.NET 아키텍처를 나타내는 클래스에 대한 액세스를 제공합니다. ADO.NET을 통해 여러 데이터 원본의 데이터를 효율적으로 관리할 수 있는 구성 요소를 만들 수 있습니다.
using System.Drawing;
//GDI+ 기본 그래픽 기능에 대한 액세스를 제공합니다.
using System.Linq;
//LINQ(Language-Integrated Query)를 사용하는 쿼리를 지원하는 클래스 및 인터페이스를 제공합니다.
using System.Text;
//ASCII 및 유니코드 문자 인코딩을 나타내는 클래스, 문자 블록과 바이트 블록 간을 변환하기 위한 추상 기본 클래스, String의 중간 인스턴스를 만들지 않고 String 개체를 조작하고 서식을 지정하는 도우미 클래스가 포함되어 있습니다.
using System.Threading.Tasks;
//동시 및 비동기 코드를 작성하는 작업을 단순화하는 형식을 제공합니다. 주요 형식은 대기하고 취소될 수 있는 비동기 작업을 나타내는 Task와 값을 반환할 수 있는 작업인 Task<TResult>입니다. TaskFactory 클래스는 작업을 만들고 시작하는 정적 메서드를 제공하고, TaskScheduler 클래스는 기본 스레드 예약 인프라를 제공합니다.
using System.Windows.Forms;
//Microsoft Windows 운영 체제의 풍부한 사용자 인터페이스 기능을 활용하는 Windows 기반 애플리케이션을 만들 수 있는 클래스가 포함되어 있습니다.
//네임스페이스에 정의된 위의 형식들을 사용할수 있도록 가져옴  

namespace GomokGameProject
//아래의 클래스들을 GomokGameProject 네임스페이스 안에서 정의한다  
{
    public partial class MenuForm : Form
    //MenuForm 클래스를 다음과 같이 정의함  
    {
        public MenuForm()
        //실행  
        {
            InitializeComponent();
            //Designer에 구현되어져 있는 component 들을 불러옴  
        }

        private void singlePlayButton_Click(object sender, EventArgs e)
        // singlePlayButton_Click이 실행되면 아래의 코드가 실행됨  
        {
            Hide(); // 현재창 숨기기 
            SinglePlayForm singlePlayForm = new SinglePlayForm(); // 싱글창 객체 생성 
            singlePlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed); // 싱글폼이 닫혔을 떄는 child폼 show 
            singlePlayForm.Show(); // 싱글창 보이기 
        }

        private void exitButton_Click(object sender, EventArgs e)
        // exitButton_Click이 실행되면 아래의 코드가 실행됨  
        {
            System.Windows.Forms.Application.Exit(); // 프로그램 전체 종료 
        }

        void childForm_Closed(object sender, FormClosedEventArgs e)
        //childForm_Closed가 실행되면 아래의 코드가 실행됨  
        {
            Show(); 
            // 초기 화면 보이기  (line 38에서 숨긴 창) 
        }
    }
}
