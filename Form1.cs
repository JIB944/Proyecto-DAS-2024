using System;
using System.Windows.Forms;
using Proyecto_DAS_2024;
using TiendaMinorista.Datos;

public partial class Form1 : Form
{
    private readonly ApplicationDbContext _dbContext;

    public Form1(ApplicationDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;

        // Ahora puedes usar _dbContext para acceder a la base de datos
    }

    private static void InitializeComponent()
    {
        // Aquí va el código de inicialización de los componentes del formulario
    }
}

