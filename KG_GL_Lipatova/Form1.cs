using System;
using System.Windows.Forms;
using SharpGL;
using System.Media;
namespace KG_GL_Lipatova
{
    public partial class Form1 : Form
    {


        SoundPlayer sp;//объявляем поле типа SoundPlayer
        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer();//создаем экземпляр класса SoundPlayer   
            //вытягиваем из ресурсов звуковой файл  
            sp.Stream = Properties.Resources.John;
            sp.Play();//начинаем проигрывание 
        }
        float rquad = 0;
        float rtri = 0;
        private SharpGL.SceneGraph.Assets.Texture texture;
        private IntPtr ptrBall;

        private void openGLControl1_OpenGLDraw(object sender, PaintEventArgs e)
        {

                OpenGL gl = this.openGLControl1.OpenGL;
                // Очистка экрана и буфера глубин
                gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

                ///////////////////////////////первый СЛОЙ//////////////////////////////////////
                // Сбрасываем модельно-видовую матрицу 
                gl.LoadIdentity();
                // Сдвигаем перо вправо от центра и вглубь экрана, но уже дальше
                gl.Translate(0.0f, -2.0f, -14.5f);
                // Вращаем куб вокруг его диагонали
                gl.Rotate(rquad, 0.0f, 1.0f, 0.0f);
                // Рисуем квадраты - грани куба
                gl.Begin(OpenGL.GL_QUADS);
                // Top
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Vertex(1.0f, 1.0f, 1.0f);
                // левая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Color(0.0f, 5.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Vertex(1.0f, 1.0f, -1.0f);
                // задняя стенка
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 2.0f);//зелёный
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.End();
                // Контроль полной отрисовки следующего изображения
                gl.Flush();
                // Меняем угол поворота 

                gl.LoadIdentity();
                gl.Translate(0.0f, -2.0f, -14.5f);
                gl.Rotate(rquad + 90, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);

                // Top
                gl.Color(0.0f, 8.0f, 0.0f);
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Vertex(1.0f, 1.0f, 1.0f);
                // левая сторона
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Vertex(4.0f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, -1.0f);
                // задняя стенка
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-4.0f, -1.0f, 0.0f);
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Vertex(4.0f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.End(); gl.Flush();
                ///////////////////////////////ВТОРОЙ СЛОЙ//////////////////////////////////////

                gl.LoadIdentity();
                gl.Translate(0.0f, 0.0f, -14.5f);
                gl.Rotate(rquad + 135, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);
                // Top
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, -1.0f);

                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                // ЛЕВАЯ
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.4f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(1.0f, 1.0f, -1.0f);
                // задняя стенка
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.End(); gl.Flush();

                gl.LoadIdentity();
                gl.Translate(0.0f, 0.0f, -14.5f);
                gl.Rotate(rquad - 135, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);
                // Top
                gl.Color(0.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Vertex(1.0f, 1.0f, 1.0f);
                // ЛЕВАЯ
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Vertex(3.4f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Vertex(1.0f, 1.0f, -1.0f);
                // задняя стенка
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-3.4f, -1.0f, 0.0f);
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 1.0f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(3.4f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.End(); gl.Flush();
                ///////////////////////////////   3  СЛОЙ    //////////////////////////////////////

                gl.LoadIdentity();
                gl.Translate(0.0f, 2.0f, -14.5f);
                gl.Rotate(rquad, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);

                // Top
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.6f, -1.0f);
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Vertex(1.0f, 0.6f, 1.0f);
                // ЛЕВАЯ
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.6f, 1.0f);
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Vertex(3.0f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Vertex(1.0f, 0.6f, -1.0f);
                // задняя стенка
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 0.6f, -1.0f);
                gl.Vertex(1.0f, 0.6f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.End(); gl.Flush();

                gl.LoadIdentity();
                gl.Translate(0.0f, 2.0f, -14.5f);
                gl.Rotate(rquad + 90, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);
                // Top
                gl.Color(0.0f, 0.6f, 0.0f);
                gl.Vertex(1.0f, 0.6f, -1.0f);
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Vertex(1.0f, 0.6f, 1.0f);

                // ЛЕВАЯ
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(1.0f, 0.6f, 1.0f);
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Vertex(3.0f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Vertex(1.0f, 0.6f, -1.0f);
                // задняя стенка
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 0.6f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.6f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                gl.Vertex(-3.0f, -1.0f, 0.0f);
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);
                gl.Vertex(1.0f, 0.6f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.6f, 1.0f);
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(3.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.End(); gl.Flush();


                ///////////////////////////////   4  СЛОЙ    //////////////////////////////////////

                gl.LoadIdentity();
                gl.Translate(0.0f, 3.6f, -14.5f);
                gl.Rotate(rquad + 135, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);

                // Top
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.3f, -1.0f);
                gl.Vertex(-1.0f, 0.3f, -1.0f);

                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Vertex(1.0f, 0.3f, 1.0f);
                // ЛЕВАЯ
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(1.0f, 0.3f, 1.0f);
                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(2.0f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.3f, -1.0f);
                gl.Vertex(1.0f, 0.3f, -1.0f);
                // задняя стенка
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-1.0f, 0.3f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                // перед
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.3f, -1.0f);
                gl.Vertex(1.0f, 0.3f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.End(); gl.Flush();

                gl.LoadIdentity();
                gl.Translate(0.0f, 3.6f, -14.5f);
                gl.Rotate(rquad - 135, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_QUADS);
                // Top
                gl.Color(0.0f, 0.3f, 0.0f);
                gl.Vertex(1.0f, 0.3f, -1.0f);
                gl.Vertex(-1.0f, 0.3f, -1.0f);
                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Vertex(1.0f, 0.3f, 1.0f);
                // ЛЕВАЯ
                gl.Color(1.0f, 3.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(1.0f, 0.3f, 1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(2.0f, -1.0f, 0.0f);
                // правая сторона
                gl.Color(0.0f, 5.0f, 0.0f);
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Vertex(-1.0f, 0.3f, -1.0f);
                gl.Color(0.0f, 5.0f, 5.0f);//голубой
                gl.Vertex(1.0f, 0.3f, -1.0f);
                // задняя стенка
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(-1.0f, 0.3f, 1.0f);
                gl.Vertex(-1.0f, 0.3f, -1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Vertex(-2.0f, -1.0f, 0.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                // перед
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(1.0f, 0.3f, -1.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(1.0f, 0.3f, 1.0f);
                gl.Color(4.0f, 4.0f, 1.0f);//белый
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.Color(0.0f, 5.0f, 0.0f);//зелёный
                gl.Vertex(2.0f, -1.0f, 0.0f);
                gl.End(); gl.Flush();



                rquad -= 3.0f;
                /////////////////////////////////////верх///////////////////////////////////////
                gl.LoadIdentity();
                gl.Translate(0.0f, 4.9f, -14.5f);
                gl.Rotate(rtri, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_TRIANGLES);
                // Front
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);

                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.Begin(OpenGL.GL_TRIANGLES);
                gl.End(); gl.Flush();

                gl.LoadIdentity();
                gl.Translate(0.0f, 4.9f, -14.5f);
                gl.Rotate(rtri + 45, 0.0f, 1.0f, 0.0f);
                gl.Begin(OpenGL.GL_TRIANGLES);
                // Front
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(0.0f, 1.0f, 0.0f); gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(0.0f, 1.0f, 0.0f); gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(0.0f, 1.0f, 0.0f); gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(0.0f, 1.0f, 0.0f); gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.End(); gl.Flush();


                ///////////////////////////////   декор   //////////////////////////////////////

                gl.LoadIdentity(); gl.Translate(0.0f, -2f, -14.5f);
                gl.Rotate(rtri, 0.0f, 1.0f, 0.0f); gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.End(); gl.Flush();

                gl.LoadIdentity(); gl.Translate(0.0f, 0f, -14.5f);
                gl.Rotate(rtri + 45, 0.0f, 1.0f, 0.0f); gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(2.0f, 0.0f, 0.0f);//красный
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.End(); gl.Flush();


                gl.LoadIdentity(); gl.Translate(0.0f, 2f, -14.5f);
                gl.Rotate(rtri, 0.0f, 1.0f, 0.0f); gl.Begin(OpenGL.GL_TRIANGLES);
                // Front
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//тсиний
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.End(); gl.Flush();

                gl.LoadIdentity(); gl.Translate(0.0f, 3.6f, -14.5f);
                gl.Rotate(rtri + 45, 0.0f, 1.0f, 0.0f); gl.Begin(OpenGL.GL_TRIANGLES);
                // Front
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Right
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(1.0f, -1.0f, 1.0f);
                // Back
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                // Left
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(0.0f, 1.0f, 0.0f);
                gl.Color(3.0f, 0.0f, 2.0f);//фиолетовый
                gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.Color(2.0f, 5.0f, 0.0f);//жёлтый
                gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.End(); gl.Flush();
                rtri -= 3.0f;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {

            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0, 0, 0, 1);//  Устанавливаем цвет заливки по умолчанию (в данном случае цвет голубой)
            //Инициализировать текстуру
            texture = new SharpGL.SceneGraph.Assets.Texture();
            //texture.Create(gl, "Data/earth.bmp"); //Загружаем изображение планеты
            //Инициализировать планету
            ptrBall = gl.NewQuadric();

            gl.Enable(OpenGL.GL_TEXTURE_2D); //Наложение текстуры
        }

    }
}

