using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;
using Validaciones;

namespace Micelli.Martin
{
    public partial class FrmPrincipal : Form
    {
        private List<Aula> listadoAulas = new List<Aula>();       
        private List<Responsable> listadoResponsables = new List<Responsable>();
        private List<Administrativo> listadoAdministrativos = new List<Administrativo>();

        private List<Alumno> listadoAlumnosSinAula = new List<Alumno>();
        private List<Docente> listadoDocentesSinAula = new List<Docente>();

        private List<Alumno> listadoAlumnosConAula = new List<Alumno>();
        private List<Docente> listadoDocentesConAula = new List<Docente>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Archivo

        private void tsmiAltaDocente_Click(object sender, EventArgs e)
        {
            FrmAltaDocente f = new FrmAltaDocente(this.listadoDocentesSinAula, this.listadoDocentesConAula);
            f.ShowDialog();

            if(f.DialogResult == DialogResult.OK)
            {
                //Inicialmente un docente no tiene ningun aula asignada
                this.listadoDocentesSinAula.Add(f.Docente);
                MessageBox.Show("Docente agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Se reproducira un archivo de audio al agregar un docente con exito
                //El archivo de audio a reproducir esta guardado en la propiedad Recursos de el proyecto Micelli.Martin
                SoundPlayer sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.tada);
                sPlayer.Play();
            }
        }

        private void tsmiAltaNoDocente_Click(object sender, EventArgs e)
        {         
            FrmAltaNoDocente f = new FrmAltaNoDocente(this.listadoAdministrativos);
            f.ShowDialog();
        
            if (f.DialogResult == DialogResult.OK)
            {
                this.listadoAdministrativos.Add(f.Administrativo);
                MessageBox.Show("No docente agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                SoundPlayer sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.tada);
                sPlayer.Play();
            }                       
        }

        private void tsmiAltaAlumno_Click(object sender, EventArgs e)
        {
            //Primero genero el responsable y despues el alumno, al final le llegan ambos objetos a este formulario
            FrmAltaResponsable f = new FrmAltaResponsable(this.listadoResponsables, this.listadoAlumnosSinAula, this.listadoAlumnosConAula);
            f.ShowDialog();

            if(f.DialogResult == DialogResult.OK)
            {
                //Inicialmente un alumno no tiene ningun aula asignada
                this.listadoAlumnosSinAula.Add(f.Alumno);
                this.listadoResponsables.Add(f.Responsable);

                MessageBox.Show("Alumno agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Responsable agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                SoundPlayer sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.tada);
                sPlayer.Play();
            }
        }
      
        private void tsmiAltaAula_Click(object sender, EventArgs e)
        {
            FrmAltaAula f = new FrmAltaAula(this.listadoAlumnosSinAula, this.listadoAlumnosConAula, this.listadoDocentesSinAula, this.listadoDocentesConAula);
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                this.lstboxListaAulas.Items.Add(f.Aula);
                this.listadoAulas.Add(f.Aula);
               
                MessageBox.Show("Aula agregada al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                SoundPlayer sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.tada);
                sPlayer.Play();
            }
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion       

        #region Reporte

        private void tsmiInformacionPadres_Click(object sender, EventArgs e)
        {
            FrmInformacionPadres f = new FrmInformacionPadres(this.listadoAulas);
            f.ShowDialog();
        }

        private void tsmiSueldoNoDocente_Click(object sender, EventArgs e)
        {
            FrmSueldoNoDocente f = new FrmSueldoNoDocente(this.listadoAdministrativos);
            f.ShowDialog();
        }

        private void tsmiRecaudacionPorAula_Click(object sender, EventArgs e)
        {
            FrmRecuadacionPorAula f = new FrmRecuadacionPorAula(this.listadoAulas);
            f.ShowDialog();
        }

        private void tsmiRecaudacionTotalPorJardin_Click(object sender, EventArgs e)
        {
            FrmRecaudacionTotalJardin f = new FrmRecaudacionTotalJardin(this.listadoAulas);
            f.ShowDialog();
        }

        private void tsmiSueldoDocente_Click(object sender, EventArgs e)
        {
            FrmSueldoDocente f = new FrmSueldoDocente(this.listadoDocentesSinAula, this.listadoDocentesConAula);
            f.ShowDialog();
        }

        #endregion

        #region Funciones Varias

        private void tsmiBuscarAlumnoPorApellido_Click(object sender, EventArgs e)
        {
            FrmBuscadorDeAlumno f = new FrmBuscadorDeAlumno(this.listadoAlumnosSinAula, this.listadoAlumnosConAula);
            f.ShowDialog();
        }

        private void tsmiEscucharMusica_Click(object sender, EventArgs e)
        {
            FrmMusica f = new FrmMusica();
            f.ShowDialog();
        }

        private void tsmiVerVideos_Click(object sender, EventArgs e)
        {
            FrmVideos f = new FrmVideos();
            f.ShowDialog();
        }

        #endregion

        #region Instanciar objetos

        private void tsmiInstanciarObjetos_Click(object sender, EventArgs e)
        {
            //Instancio los objetos y los agrega a los listados correspondientes

            //5 docentes

            //Horarios mañana
            DateTime horaEntradaMañana = new DateTime();
            DateTime horaSalidaMañana = new DateTime();

            horaEntradaMañana = horaEntradaMañana.AddHours(8);
            horaSalidaMañana = horaSalidaMañana.AddHours(13);

            //Horarios tarde
            DateTime horaEntradaTarde = new DateTime();
            DateTime horaSalidaTarde = new DateTime();

            horaEntradaTarde = horaEntradaTarde.AddHours(14);
            horaSalidaTarde = horaSalidaTarde.AddHours(19);

            Docente d1 = new Docente("Pedro", "Perez", 20123456, false, horaEntradaMañana, horaSalidaMañana, 125);
            Docente d2 = new Docente("Magdalena", "Rodriguez", 25456987, true, horaEntradaMañana, horaSalidaMañana, 115);
            Docente d3 = new Docente("Julian", "Dominguez", 30123456, false, horaEntradaTarde, horaSalidaTarde, 125);
            Docente d4 = new Docente("Romina", "Guzman", 22123654, true, horaEntradaTarde, horaSalidaTarde, 150);
            Docente d5 = new Docente("Susana", "Vidal", 28999111, true, horaEntradaMañana, horaSalidaMañana, 175);

            //Los agrego a la lista de profes sin aula:
            this.listadoDocentesSinAula.Add(d1);
            this.listadoDocentesSinAula.Add(d2);
            this.listadoDocentesSinAula.Add(d3);
            this.listadoDocentesSinAula.Add(d4);
            this.listadoDocentesSinAula.Add(d5);

            //10 no docentes

            Administrativo a1 = new Administrativo("Aristobulo", "Perroni", 21159753, false, horaEntradaMañana, horaSalidaMañana, ECargo.Cocina);
            Administrativo a2 = new Administrativo("Florencia", "Acuña", 22963258, true, horaEntradaTarde, horaSalidaTarde, ECargo.Direccion);
            Administrativo a3 = new Administrativo("Gustavo", "Ripoli", 23149625, false, horaEntradaMañana, horaSalidaMañana, ECargo.Porteria);
            Administrativo a4 = new Administrativo("Graciela", "Sanchez", 24023487, true, horaEntradaTarde, horaSalidaTarde, ECargo.Secretaria);
            Administrativo a5 = new Administrativo("German", "Caballero", 25159263, false, horaEntradaMañana, horaSalidaMañana, ECargo.Tesoreria);
            Administrativo a6 = new Administrativo("Cristina", "Duarte", 26326986, true, horaEntradaTarde, horaSalidaTarde, ECargo.Cocina);
            Administrativo a7 = new Administrativo("Dante", "Escovar", 27489156, false, horaEntradaMañana, horaSalidaMañana, ECargo.Direccion);
            Administrativo a8 = new Administrativo("Isabella", "Fuentes", 28333666, true, horaEntradaTarde, horaSalidaTarde, ECargo.Porteria);
            Administrativo a9 = new Administrativo("Tomas", "Gaitan", 29147456, false, horaEntradaMañana, horaSalidaMañana, ECargo.Secretaria);
            Administrativo a10 = new Administrativo("Carolina", "Heredia", 30335577, true, horaEntradaTarde, horaSalidaTarde, ECargo.Tesoreria);

            //Los agrego a la lista de administrativos:
            this.listadoAdministrativos.Add(a1);
            this.listadoAdministrativos.Add(a2);
            this.listadoAdministrativos.Add(a3);
            this.listadoAdministrativos.Add(a4);
            this.listadoAdministrativos.Add(a5);
            this.listadoAdministrativos.Add(a6);
            this.listadoAdministrativos.Add(a7);
            this.listadoAdministrativos.Add(a8);
            this.listadoAdministrativos.Add(a9);
            this.listadoAdministrativos.Add(a10);

            //50 responsables para 50 alumnos

            Responsable r1 = new Responsable("Allx", "Acomb", 22481594, false, eParentesco.Abuelo, "41223182");
            Responsable r2 = new Responsable("Harlin", "Emloch", 27642944, false, eParentesco.Padre, "09388884");
            Responsable r3 = new Responsable("Abbie", "Fedder", 26667030, true, eParentesco.Otro, "99095670");
            Responsable r4 = new Responsable("Matthieu", "Parmenter", 21139158, false, eParentesco.Padre, "85497704");
            Responsable r5 = new Responsable("Dasya", "Baselli", 20470624, true, eParentesco.Madre, "38631133");
            Responsable r6 = new Responsable("Porter", "McCromley", 21059125, false, eParentesco.Tio, "87224677");
            Responsable r7 = new Responsable("Hildagard", "Naismith", 20823736, true, eParentesco.Abuela, "11177157");
            Responsable r8 = new Responsable("Kenny", "Ucchino", 21512133, false, eParentesco.Abuelo, "64705021");
            Responsable r9 = new Responsable("Leupold", "Shelp", 27422080, false, eParentesco.Otro, "11601530");
            Responsable r10 = new Responsable("Guillermo", "Linebarger", 21580213, false, eParentesco.Tio, "47641508");
            Responsable r11 = new Responsable("Eda", "Delcastel", 21575749, true, eParentesco.Madre, "46998505");
            Responsable r12 = new Responsable("Oralie", "Heggadon", 28487753, true, eParentesco.Tia, "84742748");
            Responsable r13 = new Responsable("Layton", "Fairtlough", 27914192, false, eParentesco.Tio, "84881497");
            Responsable r14 = new Responsable("Warden", "Popov", 25132999, false, eParentesco.Abuelo, "51402835");
            Responsable r15 = new Responsable("Grier", "Vallack", 27823068, true, eParentesco.Madre, "63373000");
            Responsable r16 = new Responsable("Anders", "Geeritz", 26829107, false, eParentesco.Padre, "69103489");
            Responsable r17 = new Responsable("Letti", "Stute", 29312152, true, eParentesco.Tia, "44172628");
            Responsable r18 = new Responsable("Tabatha", "Ekins", 29791034, true, eParentesco.Abuela, "61557126");
            Responsable r19 = new Responsable("Jolyn", "Renny", 21056449, true, eParentesco.Otro, "85205122");
            Responsable r20 = new Responsable("Florida", "Scholz", 26251277, true, eParentesco.Tia, "16029896");
            Responsable r21 = new Responsable("Kendre", "Ramage", 29385491, false, eParentesco.Abuelo, "72253851");
            Responsable r22 = new Responsable("Joscelin", "Shimuk", 28209641, true, eParentesco.Madre, "35622657");
            Responsable r23 = new Responsable("Marge", "Pepall", 28916437, true, eParentesco.Tia, "18695752");
            Responsable r24 = new Responsable("Dunstan", "Narducci", 20853653, false, eParentesco.Otro, "39457457");
            Responsable r25 = new Responsable("Marje", "Rowbotham", 26429320, true, eParentesco.Abuela, "93906594");
            Responsable r26 = new Responsable("Jorge", "Leagas", 25649624, true, eParentesco.Abuelo, "43321245");
            Responsable r27 = new Responsable("Lucho", "Blondin", 21757614, false, eParentesco.Otro, "43673228");
            Responsable r28 = new Responsable("Robinet", "Ricca", 23593569, false, eParentesco.Abuelo, "423609612");
            Responsable r29 = new Responsable("Sisely", "Labden", 22565998, true, eParentesco.Tia, "43647188");
            Responsable r30 = new Responsable("Aurelia", "Langstone", 22109999, true, eParentesco.Abuela, "42542859");
            Responsable r31 = new Responsable("Barthel", "Hadny", 21144840, false, eParentesco.Abuelo, "42690057");
            Responsable r32 = new Responsable("Frans", "Udey", 24587642, false, eParentesco.Tio, "2866104");
            Responsable r33 = new Responsable("Kendall", "Filchakov", 22506883, true, eParentesco.Tia, "43296663");
            Responsable r34 = new Responsable("Gabbie", "Fairholme", 21702335, true, eParentesco.Tia, "43401841");
            Responsable r35 = new Responsable("Thomasina", "Casolla", 25432718, true, eParentesco.Abuela, "42471108");
            Responsable r36 = new Responsable("Lenee", "Antoniewski", 21889281, true, eParentesco.Otro, "43696856");
            Responsable r37 = new Responsable("Gilburt", "Vasilevich", 22269019, false, eParentesco.Padre, "42923103");
            Responsable r38 = new Responsable("Ainslie", "Grealey", 22425417, false, eParentesco.Padre, "42895859");
            Responsable r39 = new Responsable("Loria", "Toplin", 21562149, true, eParentesco.Madre, "43608486");
            Responsable r40 = new Responsable("Brittaney", "Laslett", 24784504, true, eParentesco.Abuela, "43514596");
            Responsable r41 = new Responsable("Hall", "Ligoe", 21594353, false, eParentesco.Tio, "42520598");
            Responsable r42 = new Responsable("Nikita", "Brosi", 25420808, true, eParentesco.Madre, "43249053");
            Responsable r43 = new Responsable("Hortense", "Flode", 21979385, false, eParentesco.Abuelo, "42453012");
            Responsable r44 = new Responsable("Noelani", "Dammarell", 21509783, true, eParentesco.Abuela, "43414353");
            Responsable r45 = new Responsable("Bogey", "Jerromes", 21288028, false, eParentesco.Padre, "42729092");
            Responsable r46 = new Responsable("Andonis", "Trangmar", 22071100, false, eParentesco.Otro, "42732865");
            Responsable r47 = new Responsable("Darcy", "Onn", 23539310, false, eParentesco.Tio, "42731332");
            Responsable r48 = new Responsable("Daune", "Wehden", 25192956, true, eParentesco.Madre, "42873636");
            Responsable r49 = new Responsable("Katrinka", "Gowers", 23731813, true, eParentesco.Tia, "43679103");
            Responsable r50 = new Responsable("Evyn", "Purle", 25289283, true, eParentesco.Madre, "43007610");

            this.listadoResponsables.Add(r1);
            this.listadoResponsables.Add(r2);
            this.listadoResponsables.Add(r3);
            this.listadoResponsables.Add(r4);
            this.listadoResponsables.Add(r5);
            this.listadoResponsables.Add(r6);
            this.listadoResponsables.Add(r7);
            this.listadoResponsables.Add(r8);
            this.listadoResponsables.Add(r9);
            this.listadoResponsables.Add(r10);
            this.listadoResponsables.Add(r11);
            this.listadoResponsables.Add(r12);
            this.listadoResponsables.Add(r13);
            this.listadoResponsables.Add(r14);
            this.listadoResponsables.Add(r15);
            this.listadoResponsables.Add(r16);
            this.listadoResponsables.Add(r17);
            this.listadoResponsables.Add(r18);
            this.listadoResponsables.Add(r19);
            this.listadoResponsables.Add(r20);
            this.listadoResponsables.Add(r21);
            this.listadoResponsables.Add(r22);
            this.listadoResponsables.Add(r23);
            this.listadoResponsables.Add(r24);
            this.listadoResponsables.Add(r25);
            this.listadoResponsables.Add(r26);
            this.listadoResponsables.Add(r27);
            this.listadoResponsables.Add(r28);
            this.listadoResponsables.Add(r29);
            this.listadoResponsables.Add(r30);
            this.listadoResponsables.Add(r31);
            this.listadoResponsables.Add(r32);
            this.listadoResponsables.Add(r33);
            this.listadoResponsables.Add(r34);
            this.listadoResponsables.Add(r35);
            this.listadoResponsables.Add(r36);
            this.listadoResponsables.Add(r37);
            this.listadoResponsables.Add(r38);
            this.listadoResponsables.Add(r39);
            this.listadoResponsables.Add(r40);
            this.listadoResponsables.Add(r41);
            this.listadoResponsables.Add(r42);
            this.listadoResponsables.Add(r43);
            this.listadoResponsables.Add(r44);
            this.listadoResponsables.Add(r45);
            this.listadoResponsables.Add(r46);
            this.listadoResponsables.Add(r47);
            this.listadoResponsables.Add(r48);
            this.listadoResponsables.Add(r49);
            this.listadoResponsables.Add(r50);

            //50 alumnos

            Alumno al1 = new Alumno("Florian", "Balazot", 41080097, false, 8012, EColores.Naranja, 1000, r1);
            Alumno al2 = new Alumno("Agosto", "Blizard", 41361467, false, 8781, EColores.Verde, 1001, r2);
            Alumno al3 = new Alumno("Mandel", "Janak", 41163467, false, 8347, EColores.Rojo, 1002, r3);
            Alumno al4 = new Alumno("Harmonie", "Mawer", 40456614, true, 8378, EColores.Amarillo, 1003, r4);
            Alumno al5 = new Alumno("Emelda", "Whitmell", 41346215, true, 7507, EColores.Amarillo, 1004, r5);
            Alumno al6 = new Alumno("Marita", "Getsham", 41989415, true, 8530, EColores.Amarillo, 1005, r6);
            Alumno al7 = new Alumno("Pegeen", "Willatts", 41110237, true, 7533, EColores.Naranja, 1006, r7);
            Alumno al8 = new Alumno("Diarmid", "Reader", 40073833, false, 9337, EColores.Naranja, 1007, r8);
            Alumno al9 = new Alumno("Sondra", "Illingsworth", 41337090, true, 7650, EColores.Rojo, 1008, r9);
            Alumno al10 = new Alumno("Judas", "Sloyan", 40668450, false, 9359, EColores.Naranja, 1009, r10);
            Alumno al11 = new Alumno("Heriberto", "Popland", 41551413, false, 9247, EColores.Naranja, 1010, r11);
            Alumno al12 = new Alumno("Fancy", "Hucker", 40303851, true, 8505, EColores.Verde, 1011, r12);
            Alumno al13 = new Alumno("Nevin", "Tunney", 41654709, false, 8823, EColores.Naranja, 1012, r13);
            Alumno al14 = new Alumno("Mehetabel", "Purser", 41000277, true, 9359, EColores.Verde, 1013, r14);
            Alumno al15 = new Alumno("Merl", "Razoux", 40428604, true, 9857, EColores.Verde, 1014, r15);
            Alumno al16 = new Alumno("Giulietta", "Kentwell", 40515570, true, 7803, EColores.Amarillo, 1015, r16);
            Alumno al17 = new Alumno("Evita", "Wichard", 41008043, true, 9222, EColores.Naranja, 1016, r17);
            Alumno al18 = new Alumno("Aurelie", "Brandone", 40775403, true, 7695, EColores.Amarillo, 1017, r18);
            Alumno al19 = new Alumno("Maud", "Van der Kruys", 40869178, true, 8762, EColores.Rojo, 1018, r19);
            Alumno al20 = new Alumno("Nick", "Symcoxe", 40515715, false, 9747, EColores.Amarillo, 10019, r20);
            Alumno al21 = new Alumno("Noelyn", "Flecknoe", 41166611, true, 8145, EColores.Amarillo, 1020, r21);
            Alumno al22 = new Alumno("Jania", "Matyugin", 41281551, true, 8016, EColores.Naranja, 10021, r22);
            Alumno al23 = new Alumno("Jacinthe", "Caughan", 40713284, false, 8100, EColores.Verde, 1022, r23);
            Alumno al24 = new Alumno("Jobi", "Tilberry", 41628575, false, 9722, EColores.Verde, 10023, r24);
            Alumno al25 = new Alumno("Kriste", "Silverthorn", 41300252, true, 9827, EColores.Rojo, 1024, r25);
            Alumno al26 = new Alumno("Carri", "Gilham", 41394992, true, 9706, EColores.Amarillo, 1025, r26);
            Alumno al27 = new Alumno("Vic", "Woodwin", 40918939, false, 9457, EColores.Naranja, 1026, r27);
            Alumno al28 = new Alumno("Lisabeth", "Calder", 40431574, true, 8242, EColores.Naranja, 1027, r28);
            Alumno al29 = new Alumno("Emile", "Knowles", 40964926, true, 7507, EColores.Rojo, 1028, r29);
            Alumno al30 = new Alumno("Sherill", "Pablos", 41991038, true, 9605, EColores.Amarillo, 1029, r30);
            Alumno al31 = new Alumno("Lynea", "Rubrow", 41100348, true, 9020, EColores.Amarillo, 1030, r31);
            Alumno al32 = new Alumno("Elaina", "Cattell", 40584748, true, 8481, EColores.Rojo, 1031, r32);
            Alumno al33 = new Alumno("Esteban", "Burkart", 41548136, false, 8083, EColores.Amarillo, 1032, r33);
            Alumno al34 = new Alumno("Gale", "Pennells", 41949870, false, 9736, EColores.Naranja, 1033, r34);
            Alumno al35 = new Alumno("Ricardo", "Pierson", 40172538, false, 7706, EColores.Rojo, 1034, r35);
            Alumno al36 = new Alumno("Bernardine", "Emeney", 41345694, true, 7511, EColores.Rojo, 1035, r36);
            Alumno al37 = new Alumno("Jaime", "Tembridge", 41911675, false, 9091, EColores.Rojo, 1036, r37);
            Alumno al38 = new Alumno("Basia", "Pulteneye", 41264762, true, 8049, EColores.Rojo, 1037, r38);
            Alumno al39 = new Alumno("Albina", "Bedow", 41298843, true, 8300, EColores.Rojo, 1038, r39);
            Alumno al40 = new Alumno("Kale", "Larn", 41165826, true, 8696, EColores.Rojo, 1039, r40);
            Alumno al41 = new Alumno("Montgomery", "Gottelier", 41988076, true, 8089, EColores.Amarillo, 1040, r41);
            Alumno al42 = new Alumno("Mirabel", "Halliburton", 41937909, true, 9633, EColores.Verde, 1041, r42);
            Alumno al43 = new Alumno("Roda", "Faussett", 41589019, true, 7669, EColores.Rojo, 1042, r43);
            Alumno al44 = new Alumno("Carmelle", "McMeeking", 41214197, false, 8050, EColores.Rojo, 1043, r44);
            Alumno al45 = new Alumno("Rochella", "Hallums", 41940501, true, 9472, EColores.Naranja, 1044, r45);
            Alumno al46 = new Alumno("Sasha", "Skillings", 41284202, true, 9997, EColores.Naranja, 1045, r46);
            Alumno al47 = new Alumno("Reinhard", "Gallimore", 41229537, false, 8034, EColores.Verde, 1046, r47);
            Alumno al48 = new Alumno("Sorcha", "Paulusch", 40827749, true, 7838, EColores.Rojo, 1047, r48);
            Alumno al49 = new Alumno("Charmine", "Cardoso", 41907259, true, 8730, EColores.Naranja, 1048, r49);
            Alumno al50 = new Alumno("Hephzibah", "Kenney", 41404565, false, 7995, EColores.Verde, 1049, r50);

            this.listadoAlumnosSinAula.Add(al1);
            this.listadoAlumnosSinAula.Add(al2);
            this.listadoAlumnosSinAula.Add(al3);
            this.listadoAlumnosSinAula.Add(al4);
            this.listadoAlumnosSinAula.Add(al5);
            this.listadoAlumnosSinAula.Add(al6);
            this.listadoAlumnosSinAula.Add(al7);
            this.listadoAlumnosSinAula.Add(al8);
            this.listadoAlumnosSinAula.Add(al9);
            this.listadoAlumnosSinAula.Add(al10);
            this.listadoAlumnosSinAula.Add(al11);
            this.listadoAlumnosSinAula.Add(al12);
            this.listadoAlumnosSinAula.Add(al13);
            this.listadoAlumnosSinAula.Add(al14);
            this.listadoAlumnosSinAula.Add(al15);
            this.listadoAlumnosSinAula.Add(al16);
            this.listadoAlumnosSinAula.Add(al17);
            this.listadoAlumnosSinAula.Add(al18);
            this.listadoAlumnosSinAula.Add(al19);
            this.listadoAlumnosSinAula.Add(al20);
            this.listadoAlumnosSinAula.Add(al21);
            this.listadoAlumnosSinAula.Add(al22);
            this.listadoAlumnosSinAula.Add(al23);
            this.listadoAlumnosSinAula.Add(al24);
            this.listadoAlumnosSinAula.Add(al25);
            this.listadoAlumnosSinAula.Add(al26);
            this.listadoAlumnosSinAula.Add(al27);
            this.listadoAlumnosSinAula.Add(al28);
            this.listadoAlumnosSinAula.Add(al29);
            this.listadoAlumnosSinAula.Add(al30);
            this.listadoAlumnosSinAula.Add(al31);
            this.listadoAlumnosSinAula.Add(al32);
            this.listadoAlumnosSinAula.Add(al33);
            this.listadoAlumnosSinAula.Add(al34);
            this.listadoAlumnosSinAula.Add(al35);
            this.listadoAlumnosSinAula.Add(al36);
            this.listadoAlumnosSinAula.Add(al37);
            this.listadoAlumnosSinAula.Add(al38);
            this.listadoAlumnosSinAula.Add(al39);
            this.listadoAlumnosSinAula.Add(al40);
            this.listadoAlumnosSinAula.Add(al41);
            this.listadoAlumnosSinAula.Add(al42);
            this.listadoAlumnosSinAula.Add(al43);
            this.listadoAlumnosSinAula.Add(al44);
            this.listadoAlumnosSinAula.Add(al45);
            this.listadoAlumnosSinAula.Add(al46);
            this.listadoAlumnosSinAula.Add(al47);
            this.listadoAlumnosSinAula.Add(al48);
            this.listadoAlumnosSinAula.Add(al49);
            this.listadoAlumnosSinAula.Add(al50);

            MessageBox.Show("Objetos instanciados con extio", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tsmiInstanciarObjetos.Enabled = false;
        }

        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cerrar?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //e refiera al evento, e.Cancel es una propiedad de del evento, que si esta en true lo cancela. En este casa evita el cierre.
                e.Cancel = true;
            }
        }

        private void lstboxListaAulas_DoubleClick(object sender, EventArgs e)
        {
            if (!(lstboxListaAulas.SelectedItem is null))
            {
                FrmInformacionAula f = new FrmInformacionAula((Aula)this.lstboxListaAulas.SelectedItem);
                f.ShowDialog();
            }
        }
    }
}
