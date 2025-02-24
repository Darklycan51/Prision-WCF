﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Prision
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PrisionEntities : DbContext
    {
        public PrisionEntities()
            : base("name=PrisionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_celda> tb_celda { get; set; }
        public virtual DbSet<tb_delito> tb_delito { get; set; }
        public virtual DbSet<tb_detalle_ingreso> tb_detalle_ingreso { get; set; }
        public virtual DbSet<tb_distrito> tb_distrito { get; set; }
        public virtual DbSet<tb_ingreso> tb_ingreso { get; set; }
        public virtual DbSet<tb_inscripcion> tb_inscripcion { get; set; }
        public virtual DbSet<tb_pabellon> tb_pabellon { get; set; }
        public virtual DbSet<tb_preso> tb_preso { get; set; }
        public virtual DbSet<tb_programa> tb_programa { get; set; }
        public virtual DbSet<tb_visita> tb_visita { get; set; }
        public virtual DbSet<tb_visitante> tb_visitante { get; set; }
        public virtual DbSet<vwDelitosIngreso> vwDelitosIngreso { get; set; }
        public virtual DbSet<vwIngresosPreso> vwIngresosPreso { get; set; }
        public virtual DbSet<vwProgramasIngreso> vwProgramasIngreso { get; set; }
        public virtual DbSet<vwVisitasIngreso> vwVisitasIngreso { get; set; }
    
        public virtual int usp_ActualizarIngreso(Nullable<int> codIngreso, Nullable<int> codPreso, Nullable<int> codCelda, Nullable<System.DateTime> fec_ingreso, Nullable<System.DateTime> fecSalida)
        {
            var codIngresoParameter = codIngreso.HasValue ?
                new ObjectParameter("codIngreso", codIngreso) :
                new ObjectParameter("codIngreso", typeof(int));
    
            var codPresoParameter = codPreso.HasValue ?
                new ObjectParameter("codPreso", codPreso) :
                new ObjectParameter("codPreso", typeof(int));
    
            var codCeldaParameter = codCelda.HasValue ?
                new ObjectParameter("codCelda", codCelda) :
                new ObjectParameter("codCelda", typeof(int));
    
            var fec_ingresoParameter = fec_ingreso.HasValue ?
                new ObjectParameter("fec_ingreso", fec_ingreso) :
                new ObjectParameter("fec_ingreso", typeof(System.DateTime));
    
            var fecSalidaParameter = fecSalida.HasValue ?
                new ObjectParameter("fecSalida", fecSalida) :
                new ObjectParameter("fecSalida", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarIngreso", codIngresoParameter, codPresoParameter, codCeldaParameter, fec_ingresoParameter, fecSalidaParameter);
        }
    
        public virtual int usp_ActualizarInscripcion(Nullable<int> vcodIns, Nullable<int> vcodIng, Nullable<int> vcodPro, Nullable<System.DateTime> vfecIni, Nullable<System.DateTime> vfecFini)
        {
            var vcodInsParameter = vcodIns.HasValue ?
                new ObjectParameter("vcodIns", vcodIns) :
                new ObjectParameter("vcodIns", typeof(int));
    
            var vcodIngParameter = vcodIng.HasValue ?
                new ObjectParameter("vcodIng", vcodIng) :
                new ObjectParameter("vcodIng", typeof(int));
    
            var vcodProParameter = vcodPro.HasValue ?
                new ObjectParameter("vcodPro", vcodPro) :
                new ObjectParameter("vcodPro", typeof(int));
    
            var vfecIniParameter = vfecIni.HasValue ?
                new ObjectParameter("vfecIni", vfecIni) :
                new ObjectParameter("vfecIni", typeof(System.DateTime));
    
            var vfecFiniParameter = vfecFini.HasValue ?
                new ObjectParameter("vfecFini", vfecFini) :
                new ObjectParameter("vfecFini", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarInscripcion", vcodInsParameter, vcodIngParameter, vcodProParameter, vfecIniParameter, vfecFiniParameter);
        }
    
        public virtual int usp_ActualizarPreso(Nullable<int> vcod, string vnom, string vape, string vdni, Nullable<System.DateTime> vfec, Nullable<int> vdis, string vdir)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            var vnomParameter = vnom != null ?
                new ObjectParameter("vnom", vnom) :
                new ObjectParameter("vnom", typeof(string));
    
            var vapeParameter = vape != null ?
                new ObjectParameter("vape", vape) :
                new ObjectParameter("vape", typeof(string));
    
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            var vfecParameter = vfec.HasValue ?
                new ObjectParameter("vfec", vfec) :
                new ObjectParameter("vfec", typeof(System.DateTime));
    
            var vdisParameter = vdis.HasValue ?
                new ObjectParameter("vdis", vdis) :
                new ObjectParameter("vdis", typeof(int));
    
            var vdirParameter = vdir != null ?
                new ObjectParameter("vdir", vdir) :
                new ObjectParameter("vdir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarPreso", vcodParameter, vnomParameter, vapeParameter, vdniParameter, vfecParameter, vdisParameter, vdirParameter);
        }
    
        public virtual int usp_ActualizarVisita(Nullable<int> vcod, Nullable<int> vcodI, Nullable<int> vcodV, Nullable<System.DateTime> vfec, string motivo)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            var vcodIParameter = vcodI.HasValue ?
                new ObjectParameter("vcodI", vcodI) :
                new ObjectParameter("vcodI", typeof(int));
    
            var vcodVParameter = vcodV.HasValue ?
                new ObjectParameter("vcodV", vcodV) :
                new ObjectParameter("vcodV", typeof(int));
    
            var vfecParameter = vfec.HasValue ?
                new ObjectParameter("vfec", vfec) :
                new ObjectParameter("vfec", typeof(System.DateTime));
    
            var motivoParameter = motivo != null ?
                new ObjectParameter("motivo", motivo) :
                new ObjectParameter("motivo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarVisita", vcodParameter, vcodIParameter, vcodVParameter, vfecParameter, motivoParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarDelito_Result> usp_ConsultarDelito(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarDelito_Result>("usp_ConsultarDelito", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarIngreso_Result> usp_ConsultarIngreso(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarIngreso_Result>("usp_ConsultarIngreso", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarInscripcion_Result> usp_ConsultarInscripcion(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarInscripcion_Result>("usp_ConsultarInscripcion", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarPreso_Result> usp_ConsultarPreso(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarPreso_Result>("usp_ConsultarPreso", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarPresoPorDNI_Result> usp_ConsultarPresoPorDNI(string vdni)
        {
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarPresoPorDNI_Result>("usp_ConsultarPresoPorDNI", vdniParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarPrograma_Result> usp_ConsultarPrograma(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarPrograma_Result>("usp_ConsultarPrograma", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarVisita_Result> usp_ConsultarVisita(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarVisita_Result>("usp_ConsultarVisita", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarVisitante_Result> usp_ConsultarVisitante(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarVisitante_Result>("usp_ConsultarVisitante", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarVisitantePorDNI_Result> usp_ConsultarVisitantePorDNI(string vdni)
        {
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarVisitantePorDNI_Result>("usp_ConsultarVisitantePorDNI", vdniParameter);
        }
    
        public virtual int usp_EliminarPreso(string vdni)
        {
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarPreso", vdniParameter);
        }
    
        public virtual int usp_EliminarVisita(Nullable<int> vcod)
        {
            var vcodParameter = vcod.HasValue ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarVisita", vcodParameter);
        }
    
        public virtual int usp_InsertarDetalle(Nullable<int> vcodI, Nullable<int> vcodD, string vpar)
        {
            var vcodIParameter = vcodI.HasValue ?
                new ObjectParameter("vcodI", vcodI) :
                new ObjectParameter("vcodI", typeof(int));
    
            var vcodDParameter = vcodD.HasValue ?
                new ObjectParameter("vcodD", vcodD) :
                new ObjectParameter("vcodD", typeof(int));
    
            var vparParameter = vpar != null ?
                new ObjectParameter("vpar", vpar) :
                new ObjectParameter("vpar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarDetalle", vcodIParameter, vcodDParameter, vparParameter);
        }
    
        public virtual int usp_InsertarIngreso(Nullable<int> vcodP, Nullable<int> vcodC, Nullable<System.DateTime> vfecI, Nullable<System.DateTime> vfecS)
        {
            var vcodPParameter = vcodP.HasValue ?
                new ObjectParameter("vcodP", vcodP) :
                new ObjectParameter("vcodP", typeof(int));
    
            var vcodCParameter = vcodC.HasValue ?
                new ObjectParameter("vcodC", vcodC) :
                new ObjectParameter("vcodC", typeof(int));
    
            var vfecIParameter = vfecI.HasValue ?
                new ObjectParameter("vfecI", vfecI) :
                new ObjectParameter("vfecI", typeof(System.DateTime));
    
            var vfecSParameter = vfecS.HasValue ?
                new ObjectParameter("vfecS", vfecS) :
                new ObjectParameter("vfecS", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarIngreso", vcodPParameter, vcodCParameter, vfecIParameter, vfecSParameter);
        }
    
        public virtual int usp_InsertarInscripcion(Nullable<int> vcodIng, Nullable<int> vcodPro, Nullable<System.DateTime> vfecini, Nullable<System.DateTime> vfecfin)
        {
            var vcodIngParameter = vcodIng.HasValue ?
                new ObjectParameter("vcodIng", vcodIng) :
                new ObjectParameter("vcodIng", typeof(int));
    
            var vcodProParameter = vcodPro.HasValue ?
                new ObjectParameter("vcodPro", vcodPro) :
                new ObjectParameter("vcodPro", typeof(int));
    
            var vfeciniParameter = vfecini.HasValue ?
                new ObjectParameter("vfecini", vfecini) :
                new ObjectParameter("vfecini", typeof(System.DateTime));
    
            var vfecfinParameter = vfecfin.HasValue ?
                new ObjectParameter("vfecfin", vfecfin) :
                new ObjectParameter("vfecfin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarInscripcion", vcodIngParameter, vcodProParameter, vfeciniParameter, vfecfinParameter);
        }
    
        public virtual int usp_InsertarPreso(string vnom, string vape, string vdni, Nullable<System.DateTime> vfec, Nullable<int> vdis, string vdir)
        {
            var vnomParameter = vnom != null ?
                new ObjectParameter("vnom", vnom) :
                new ObjectParameter("vnom", typeof(string));
    
            var vapeParameter = vape != null ?
                new ObjectParameter("vape", vape) :
                new ObjectParameter("vape", typeof(string));
    
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            var vfecParameter = vfec.HasValue ?
                new ObjectParameter("vfec", vfec) :
                new ObjectParameter("vfec", typeof(System.DateTime));
    
            var vdisParameter = vdis.HasValue ?
                new ObjectParameter("vdis", vdis) :
                new ObjectParameter("vdis", typeof(int));
    
            var vdirParameter = vdir != null ?
                new ObjectParameter("vdir", vdir) :
                new ObjectParameter("vdir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarPreso", vnomParameter, vapeParameter, vdniParameter, vfecParameter, vdisParameter, vdirParameter);
        }
    
        public virtual int usp_InsertarVisita(Nullable<int> vcodI, Nullable<int> vcodV, Nullable<System.DateTime> vfec, string vmo)
        {
            var vcodIParameter = vcodI.HasValue ?
                new ObjectParameter("vcodI", vcodI) :
                new ObjectParameter("vcodI", typeof(int));
    
            var vcodVParameter = vcodV.HasValue ?
                new ObjectParameter("vcodV", vcodV) :
                new ObjectParameter("vcodV", typeof(int));
    
            var vfecParameter = vfec.HasValue ?
                new ObjectParameter("vfec", vfec) :
                new ObjectParameter("vfec", typeof(System.DateTime));
    
            var vmoParameter = vmo != null ?
                new ObjectParameter("vmo", vmo) :
                new ObjectParameter("vmo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarVisita", vcodIParameter, vcodVParameter, vfecParameter, vmoParameter);
        }
    
        public virtual int usp_InsertarVisitante(string vnom, string vape, string vdni, Nullable<int> vdis, string vdir)
        {
            var vnomParameter = vnom != null ?
                new ObjectParameter("vnom", vnom) :
                new ObjectParameter("vnom", typeof(string));
    
            var vapeParameter = vape != null ?
                new ObjectParameter("vape", vape) :
                new ObjectParameter("vape", typeof(string));
    
            var vdniParameter = vdni != null ?
                new ObjectParameter("vdni", vdni) :
                new ObjectParameter("vdni", typeof(string));
    
            var vdisParameter = vdis.HasValue ?
                new ObjectParameter("vdis", vdis) :
                new ObjectParameter("vdis", typeof(int));
    
            var vdirParameter = vdir != null ?
                new ObjectParameter("vdir", vdir) :
                new ObjectParameter("vdir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarVisitante", vnomParameter, vapeParameter, vdniParameter, vdisParameter, vdirParameter);
        }
    
        public virtual ObjectResult<usp_ListarDelito_Result> usp_ListarDelito()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarDelito_Result>("usp_ListarDelito");
        }
    
        public virtual ObjectResult<usp_ListarDistrito_Result> usp_ListarDistrito()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarDistrito_Result>("usp_ListarDistrito");
        }
    
        public virtual ObjectResult<usp_ListarIngresoNombres_Result> usp_ListarIngresoNombres()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarIngresoNombres_Result>("usp_ListarIngresoNombres");
        }
    
        public virtual ObjectResult<usp_ListarPreso_Result> usp_ListarPreso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPreso_Result>("usp_ListarPreso");
        }
    
        public virtual ObjectResult<usp_ListarPrograma_Result> usp_ListarPrograma()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPrograma_Result>("usp_ListarPrograma");
        }
    
        public virtual ObjectResult<usp_ListarVisita_Result> usp_ListarVisita()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVisita_Result>("usp_ListarVisita");
        }
    
        public virtual ObjectResult<usp_ListarVisitante_Result> usp_ListarVisitante()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVisitante_Result>("usp_ListarVisitante");
        }
    }
}
