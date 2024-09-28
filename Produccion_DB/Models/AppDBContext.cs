using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion_DB.Models;

public partial class AppDBContext : DbContext
{
    public AppDBContext()
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApruebaProductoTb> ApruebaProductoTbs { get; set; }

    public virtual DbSet<ApruebaProductoTbMaxFechaApruevaVw> ApruebaProductoTbMaxFechaApruevaVws { get; set; }

    public virtual DbSet<AreaFisicaAreaTotalVw> AreaFisicaAreaTotalVws { get; set; }

    public virtual DbSet<ArticulosTb> ArticulosTbs { get; set; }

    public virtual DbSet<CamasLoteVw> CamasLoteVws { get; set; }

    public virtual DbSet<CamasLotesFisicosTb> CamasLotesFisicosTbs { get; set; }

    public virtual DbSet<CamasLotesPoTb> CamasLotesPoTbs { get; set; }

    public virtual DbSet<CentroCostoTb> CentroCostoTbs { get; set; }

    public virtual DbSet<CentroCostoVw> CentroCostoVws { get; set; }

    public virtual DbSet<CentroCostoVw1> CentroCostoVw1s { get; set; }

    public virtual DbSet<CertificacionesTb> CertificacionesTbs { get; set; }

    public virtual DbSet<CodigosTrazabilidadTb> CodigosTrazabilidadTbs { get; set; }

    public virtual DbSet<ConsultasTb> ConsultasTbs { get; set; }

    public virtual DbSet<ControlUsuarioTb> ControlUsuarioTbs { get; set; }

    public virtual DbSet<CultivoProductoFaseTb> CultivoProductoFaseTbs { get; set; }

    public virtual DbSet<DdtLaborTb> DdtLaborTbs { get; set; }

    public virtual DbSet<DepartamentoTb> DepartamentoTbs { get; set; }

    public virtual DbSet<DepartamentosConPedidosVw> DepartamentosConPedidosVws { get; set; }

    public virtual DbSet<EntregaProductoTb> EntregaProductoTbs { get; set; }

    public virtual DbSet<EstRangosPesosTb> EstRangosPesosTbs { get; set; }

    public virtual DbSet<EstSemanaTb> EstSemanaTbs { get; set; }

    public virtual DbSet<FechaCosechaMinVw> FechaCosechaMinVws { get; set; }

    public virtual DbSet<FechaTb> FechaTbs { get; set; }

    public virtual DbSet<FtAplicacionesTb> FtAplicacionesTbs { get; set; }

    public virtual DbSet<FtApruebaProductoTb> FtApruebaProductoTbs { get; set; }

    public virtual DbSet<FtApruebaProductoTbMaxFechaApruevaVw> FtApruebaProductoTbMaxFechaApruevaVws { get; set; }

    public virtual DbSet<FtEntregaProductoTb> FtEntregaProductoTbs { get; set; }

    public virtual DbSet<FtEstadoLarvaTb> FtEstadoLarvaTbs { get; set; }

    public virtual DbSet<FtEstadoLarvaTbDdtVw> FtEstadoLarvaTbDdtVws { get; set; }

    public virtual DbSet<FtLarvasMasEstadoVw> FtLarvasMasEstadoVws { get; set; }

    public virtual DbSet<FtLarvasMonitoreoTb> FtLarvasMonitoreoTbs { get; set; }

    public virtual DbSet<FtLarvasMonitoreoTbDdtVw> FtLarvasMonitoreoTbDdtVws { get; set; }

    public virtual DbSet<FtMonitoreoFrutoNombreEstadoDlarvaVw> FtMonitoreoFrutoNombreEstadoDlarvaVws { get; set; }

    public virtual DbSet<FtMonitoreoFrutoNombreEstadoDlarvaVwDdtVw> FtMonitoreoFrutoNombreEstadoDlarvaVwDdtVws { get; set; }

    public virtual DbSet<FtMonitoreoFrutoTb> FtMonitoreoFrutoTbs { get; set; }

    public virtual DbSet<FtMonitoreoFrutoTbDdtVw> FtMonitoreoFrutoTbDdtVws { get; set; }

    public virtual DbSet<FtMonitoreoFrutoTbDdtVwHa> FtMonitoreoFrutoTbDdtVwHas { get; set; }

    public virtual DbSet<FtMonitoreoPlagasTb> FtMonitoreoPlagasTbs { get; set; }

    public virtual DbSet<FtMonitoreoPlagasTbDdtVw> FtMonitoreoPlagasTbDdtVws { get; set; }

    public virtual DbSet<FtMonitoreoPlagasTbDdtVw1> FtMonitoreoPlagasTbDdtVw1s { get; set; }

    public virtual DbSet<FtMonitoreoPlagasVw> FtMonitoreoPlagasVws { get; set; }

    public virtual DbSet<FtMotivoPedidoProductosMaxFrecuenciaVw> FtMotivoPedidoProductosMaxFrecuenciaVws { get; set; }

    public virtual DbSet<FtMotivoPedidoProductosVw> FtMotivoPedidoProductosVws { get; set; }

    public virtual DbSet<FtPedidoProductosCertificacionVw> FtPedidoProductosCertificacionVws { get; set; }

    public virtual DbSet<FtPedidoProductosTb> FtPedidoProductosTbs { get; set; }

    public virtual DbSet<FtPedidoProductosTrazabilidadHibridosVw> FtPedidoProductosTrazabilidadHibridosVws { get; set; }

    public virtual DbSet<FtPedidoProductosVw> FtPedidoProductosVws { get; set; }

    public virtual DbSet<FtPedidoProductosVw1> FtPedidoProductosVw1s { get; set; }

    public virtual DbSet<FtPedidoProductosVw2> FtPedidoProductosVw2s { get; set; }

    public virtual DbSet<FtPedidoTb> FtPedidoTbs { get; set; }

    public virtual DbSet<FtRdistribuidorProductoTb> FtRdistribuidorProductoTbs { get; set; }

    public virtual DbSet<FtTurnoAplicacionTb> FtTurnoAplicacionTbs { get; set; }

    public virtual DbSet<FtTurnoMasAplicacionesDdtVw> FtTurnoMasAplicacionesDdtVws { get; set; }

    public virtual DbSet<FtTurnoMasAplicacionesDdtVwMetereologiaVw> FtTurnoMasAplicacionesDdtVwMetereologiaVws { get; set; }

    public virtual DbSet<HibridosPoTb> HibridosPoTbs { get; set; }

    public virtual DbSet<HibridosTb> HibridosTbs { get; set; }

    public virtual DbSet<HorasRiegoTb> HorasRiegoTbs { get; set; }

    public virtual DbSet<KnAjusteAzucarTb> KnAjusteAzucarTbs { get; set; }

    public virtual DbSet<KnAjusteMielTb> KnAjusteMielTbs { get; set; }

    public virtual DbSet<KnCamionesDiaTurnoVw> KnCamionesDiaTurnoVws { get; set; }

    public virtual DbSet<KnCortaCanaTb> KnCortaCanaTbs { get; set; }

    public virtual DbSet<KnDatosPorTurnoVw> KnDatosPorTurnoVws { get; set; }

    public virtual DbSet<KnDdtLaborTb> KnDdtLaborTbs { get; set; }

    public virtual DbSet<KnDiaTurnoSumasVw> KnDiaTurnoSumasVws { get; set; }

    public virtual DbSet<KnLaboresDdtProductosVw> KnLaboresDdtProductosVws { get; set; }

    public virtual DbSet<KnLaboresLotesTb> KnLaboresLotesTbs { get; set; }

    public virtual DbSet<KnLotesCanaPlantaSocaVw> KnLotesCanaPlantaSocaVws { get; set; }

    public virtual DbSet<KnLotesCanaTb> KnLotesCanaTbs { get; set; }

    public virtual DbSet<KnLotesCanaTbCortaNumVw> KnLotesCanaTbCortaNumVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas0AjusteAzucarMielVw> KnLotesCortaCarretas0AjusteAzucarMielVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas0AjusteAzucarVw> KnLotesCortaCarretas0AjusteAzucarVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas0AjusteMielVw> KnLotesCortaCarretas0AjusteMielVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas0RoundVw> KnLotesCortaCarretas0RoundVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas0Vw> KnLotesCortaCarretas0Vws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas1RoundVw> KnLotesCortaCarretas1RoundVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas1Vw> KnLotesCortaCarretas1Vws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas2RoundVw> KnLotesCortaCarretas2RoundVws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas2Vw> KnLotesCortaCarretas2Vws { get; set; }

    public virtual DbSet<KnLotesCortaCarretas3Vw> KnLotesCortaCarretas3Vws { get; set; }

    public virtual DbSet<KnLotesLaborDdtProductosVw> KnLotesLaborDdtProductosVws { get; set; }

    public virtual DbSet<KnLotesPlantaVw> KnLotesPlantaVws { get; set; }

    public virtual DbSet<KnLotesSocaVw> KnLotesSocaVws { get; set; }

    public virtual DbSet<KnPesoCarretasTb> KnPesoCarretasTbs { get; set; }

    public virtual DbSet<KnPesoCarretasVw> KnPesoCarretasVws { get; set; }

    public virtual DbSet<KnPlacaChoferTransportistaVw> KnPlacaChoferTransportistaVws { get; set; }

    public virtual DbSet<KnPoInyeccionProductosTb> KnPoInyeccionProductosTbs { get; set; }

    public virtual DbSet<KnPoLotesLaborDdtHorasTotalDiasSemanaVw> KnPoLotesLaborDdtHorasTotalDiasSemanaVws { get; set; }

    public virtual DbSet<KnPoLotesLaborDdtHorasTotalVw> KnPoLotesLaborDdtHorasTotalVws { get; set; }

    public virtual DbSet<KnPoLotesLaborDdtProductos1Vw> KnPoLotesLaborDdtProductos1Vws { get; set; }

    public virtual DbSet<KnPoLotesLaborDdtProductos2Vw> KnPoLotesLaborDdtProductos2Vws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdt1Vw> KnPoLotesLaboresDdt1Vws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosAux1Vw> KnPoLotesLaboresDdtProductosAux1Vws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosAux2Vw> KnPoLotesLaboresDdtProductosAux2Vws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosAuxVw> KnPoLotesLaboresDdtProductosAuxVws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosHorasCabezalVw> KnPoLotesLaboresDdtProductosHorasCabezalVws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosHorasCabezalVwCruzadoVw> KnPoLotesLaboresDdtProductosHorasCabezalVwCruzadoVws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtProductosVw> KnPoLotesLaboresDdtProductosVws { get; set; }

    public virtual DbSet<KnPoLotesLaboresDdtVw> KnPoLotesLaboresDdtVws { get; set; }

    public virtual DbSet<KnPoPedidoProductosDepLaborVw> KnPoPedidoProductosDepLaborVws { get; set; }

    public virtual DbSet<KnPoPedidoProductosTb> KnPoPedidoProductosTbs { get; set; }

    public virtual DbSet<KnPoPedidoProductosTbAplicacionesAdicionalesVw> KnPoPedidoProductosTbAplicacionesAdicionalesVws { get; set; }

    public virtual DbSet<KnPoPedidoProductosVw> KnPoPedidoProductosVws { get; set; }

    public virtual DbSet<KnPoPedidoProductosVw1> KnPoPedidoProductosVw1s { get; set; }

    public virtual DbSet<KnPoPedidoProductosVw2> KnPoPedidoProductosVw2s { get; set; }

    public virtual DbSet<KnPoPedidoProductosVwMaestroErdrequizaVw> KnPoPedidoProductosVwMaestroErdrequizaVws { get; set; }

    public virtual DbSet<KnProductosALaborTb> KnProductosALaborTbs { get; set; }

    public virtual DbSet<LaborTDdtVw> LaborTDdtVws { get; set; }

    public virtual DbSet<LaborTTb> LaborTTbs { get; set; }

    public virtual DbSet<LaborTVw> LaborTVws { get; set; }

    public virtual DbSet<LaboresTb> LaboresTbs { get; set; }

    public virtual DbSet<LcCtraspSembradorTb> LcCtraspSembradorTbs { get; set; }

    public virtual DbSet<LcCtraspSembradorVw> LcCtraspSembradorVws { get; set; }

    public virtual DbSet<LcMonitoreoTrasplanteTb> LcMonitoreoTrasplanteTbs { get; set; }

    public virtual DbSet<LcSembradorTb> LcSembradorTbs { get; set; }

    public virtual DbSet<LcTrasplanteHibridosTb> LcTrasplanteHibridosTbs { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorCamasRepetidasVw> LcTrasplanteLoteMonitoreoCtraspSembradorCamasRepetidasVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoFullVw> LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoFullVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoVw> LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorRfmSsemanaVw> LcTrasplanteLoteMonitoreoCtraspSembradorRfmSsemanaVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorSfechaVw> LcTrasplanteLoteMonitoreoCtraspSembradorSfechaVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorSloteVw> LcTrasplanteLoteMonitoreoCtraspSembradorSloteVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorSsemanaVw> LcTrasplanteLoteMonitoreoCtraspSembradorSsemanaVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoCtraspSembradorVw> LcTrasplanteLoteMonitoreoCtraspSembradorVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteMonitoreoVw> LcTrasplanteLoteMonitoreoVws { get; set; }

    public virtual DbSet<LcTrasplanteLoteTb> LcTrasplanteLoteTbs { get; set; }

    public virtual DbSet<LcVvTrasplanteSalidaViveroTb> LcVvTrasplanteSalidaViveroTbs { get; set; }

    public virtual DbSet<LotesFisicosTb> LotesFisicosTbs { get; set; }

    public virtual DbSet<LotesPoTb> LotesPoTbs { get; set; }

    public virtual DbSet<LotesPoTrazabilidadFechaCosechaVw> LotesPoTrazabilidadFechaCosechaVws { get; set; }

    public virtual DbSet<LotesVariedadAreaVw> LotesVariedadAreaVws { get; set; }

    public virtual DbSet<LvScizerMasRangosVw> LvScizerMasRangosVws { get; set; }

    public virtual DbSet<LvTermporadaTb> LvTermporadaTbs { get; set; }

    public virtual DbSet<LvTermporadaVersionPoTb> LvTermporadaVersionPoTbs { get; set; }

    public virtual DbSet<LvaLaborTDdt1Vw> LvaLaborTDdt1Vws { get; set; }

    public virtual DbSet<LvaLaborTDdt2Vw> LvaLaborTDdt2Vws { get; set; }

    public virtual DbSet<LvaLaborTDdt3SumAreaLaborVw> LvaLaborTDdt3SumAreaLaborVws { get; set; }

    public virtual DbSet<LvaLaborTDdtVw> LvaLaborTDdtVws { get; set; }

    public virtual DbSet<MtMetereologiaTb> MtMetereologiaTbs { get; set; }

    public virtual DbSet<MtPlubiometroTb> MtPlubiometroTbs { get; set; }

    public virtual DbSet<MtPlubiometrosMasFechasVwd> MtPlubiometrosMasFechasVwds { get; set; }

    public virtual DbSet<MtRegistroLluviasTb> MtRegistroLluviasTbs { get; set; }

    public virtual DbSet<MtRegistrosLluviasVw> MtRegistrosLluviasVws { get; set; }

    public virtual DbSet<MtSumasTotalesAfechaVw> MtSumasTotalesAfechaVws { get; set; }

    public virtual DbSet<MtSumasTotalesAfechaVw1> MtSumasTotalesAfechaVw1s { get; set; }

    public virtual DbSet<MtSumasTotalesAfechaVw2> MtSumasTotalesAfechaVw2s { get; set; }

    public virtual DbSet<MtSumasTotalesAfechaVw3> MtSumasTotalesAfechaVw3s { get; set; }

    public virtual DbSet<MtSumasTotalesVw> MtSumasTotalesVws { get; set; }

    public virtual DbSet<MtSumaxAñoAfechaVw> MtSumaxAñoAfechaVws { get; set; }

    public virtual DbSet<MtSumaxAñoVw> MtSumaxAñoVws { get; set; }

    public virtual DbSet<MtSumaxDiaVw> MtSumaxDiaVws { get; set; }

    public virtual DbSet<MtSumaxDiaVw0> MtSumaxDiaVw0s { get; set; }

    public virtual DbSet<MtSumaxMesAfechaVw> MtSumaxMesAfechaVws { get; set; }

    public virtual DbSet<MtSumaxMesVw> MtSumaxMesVws { get; set; }

    public virtual DbSet<NavegadorTb> NavegadorTbs { get; set; }

    public virtual DbSet<NavegadorVw> NavegadorVws { get; set; }

    public virtual DbSet<PilaTb> PilaTbs { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVw> PoLotesLaborDdtProductosVws { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt> PoLotesLaborDdtProductosVwFts { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt1> PoLotesLaborDdtProductosVwFt1s { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt11> PoLotesLaborDdtProductosVwFt11s { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt11Din> PoLotesLaborDdtProductosVwFt11Dins { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt1Din> PoLotesLaborDdtProductosVwFt1Dins { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt2> PoLotesLaborDdtProductosVwFt2s { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt2DinVw> PoLotesLaborDdtProductosVwFt2DinVws { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt2EstVw> PoLotesLaborDdtProductosVwFt2EstVws { get; set; }

    public virtual DbSet<PoLotesLaborDdtProductosVwFt2Master> PoLotesLaborDdtProductosVwFt2Masters { get; set; }

    public virtual DbSet<PoProductosALaborTb> PoProductosALaborTbs { get; set; }

    public virtual DbSet<ProductosCertificacionesVw> ProductosCertificacionesVws { get; set; }

    public virtual DbSet<ProductosTb> ProductosTbs { get; set; }

    public virtual DbSet<ProductosTbFaseVw> ProductosTbFaseVws { get; set; }

    public virtual DbSet<RangosScizerTb> RangosScizerTbs { get; set; }

    public virtual DbSet<RcabezaleroProductoTb> RcabezaleroProductoTbs { get; set; }

    public virtual DbSet<RdistribuidorProductoTb> RdistribuidorProductoTbs { get; set; }

    public virtual DbSet<ReporteConsultaVw> ReporteConsultaVws { get; set; }

    public virtual DbSet<RgCabezalTb> RgCabezalTbs { get; set; }

    public virtual DbSet<RgEncargadoRinyeccionTb> RgEncargadoRinyeccionTbs { get; set; }

    public virtual DbSet<RgMotor> RgMotors { get; set; }

    public virtual DbSet<RgRiegoLotesAreaRiegoVw> RgRiegoLotesAreaRiegoVws { get; set; }

    public virtual DbSet<RgRiegoLotesM3HoraHaVw> RgRiegoLotesM3HoraHaVws { get; set; }

    public virtual DbSet<RgRiegoLotesVw> RgRiegoLotesVws { get; set; }

    public virtual DbSet<RgRiegoTb> RgRiegoTbs { get; set; }

    public virtual DbSet<ScizerDatosCosechaTemporadaVw> ScizerDatosCosechaTemporadaVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvDiaMasPilaVw> ScizerMasRangosLvDiaMasPilaVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvDiaVw> ScizerMasRangosLvDiaVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvSumasDiaVw> ScizerMasRangosLvSumasDiaVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvTemporadaSnumTratVw> ScizerMasRangosLvTemporadaSnumTratVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvTemporadaTotalVw> ScizerMasRangosLvTemporadaTotalVws { get; set; }

    public virtual DbSet<ScizerMasRangosLvTemporadaVw> ScizerMasRangosLvTemporadaVws { get; set; }

    public virtual DbSet<ScizerTb> ScizerTbs { get; set; }

    public virtual DbSet<TemporadaTb> TemporadaTbs { get; set; }

    public virtual DbSet<UnionLaboresDdtProductosKnPoDepSumDosisLotesVw> UnionLaboresDdtProductosKnPoDepSumDosisLotesVws { get; set; }

    public virtual DbSet<UnionLaboresDdtProductosKnPoDepVw> UnionLaboresDdtProductosKnPoDepVws { get; set; }

    public virtual DbSet<UnionLaboresKnPoDepRealVw> UnionLaboresKnPoDepRealVws { get; set; }

    public virtual DbSet<UnionLaboresKnPoDepSumProductosRealVw> UnionLaboresKnPoDepSumProductosRealVws { get; set; }

    public virtual DbSet<UnionLaboresKnPoDepTeoricoMrealVw> UnionLaboresKnPoDepTeoricoMrealVws { get; set; }

    public virtual DbSet<UnionLaboresKnPoDepVw> UnionLaboresKnPoDepVws { get; set; }

    public virtual DbSet<UnionLaboresKnPoDepVwCruzadoVw> UnionLaboresKnPoDepVwCruzadoVws { get; set; }

    public virtual DbSet<UsuarioDepVw> UsuarioDepVws { get; set; }

    public virtual DbSet<UsuarioTb> UsuarioTbs { get; set; }

    public virtual DbSet<ValvulasTb> ValvulasTbs { get; set; }

    public virtual DbSet<VariedadTb> VariedadTbs { get; set; }

    public virtual DbSet<VersionPoTb> VersionPoTbs { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<VvAplicaTb> VvAplicaTbs { get; set; }

    public virtual DbSet<VvAplicacionTb> VvAplicacionTbs { get; set; }

    public virtual DbSet<VvGerminacionTb> VvGerminacionTbs { get; set; }

    public virtual DbSet<VvLotesSemillaTb> VvLotesSemillaTbs { get; set; }

    public virtual DbSet<VvProductosAplicadosTb> VvProductosAplicadosTbs { get; set; }

    public virtual DbSet<VvSalidaViveroTb> VvSalidaViveroTbs { get; set; }

    public virtual DbSet<VvSemillasTb> VvSemillasTbs { get; set; }

    public virtual DbSet<VvSiembraViveroTb> VvSiembraViveroTbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Produccion_DB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApruebaProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdAprueba, e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK59")
                .IsClustered(false);

            entity.ToTable("Aprueba_Producto_TB", "pd");

            entity.Property(e => e.IdAprueba)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Aprueba");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraAprueba).HasColumnName("Fecha_Hora_Aprueba");
            entity.Property(e => e.IdEmpleadoAprueva)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Aprueva");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.KnPoPedidoProductosTb).WithMany(p => p.ApruebaProductoTbs)
                .HasForeignKey(d => new { d.IdPedido, d.IdProducto, d.NumBoleta })
                .HasConstraintName("RefKN_PO_Pedido_Productos_TB169");
        });

        modelBuilder.Entity<ApruebaProductoTbMaxFechaApruevaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Aprueba_Producto_TB_Max_Fecha_Aprueva_VW", "pd");

            entity.Property(e => e.FechaHoraAprueba).HasColumnName("Fecha_Hora_Aprueba");
            entity.Property(e => e.IdEmpleadoAprueva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Aprueva");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");
        });

        modelBuilder.Entity<AreaFisicaAreaTotalVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Area_Fisica_Area_Total_VW", "pd");

            entity.Property(e => e.AreaFisica).HasColumnName("Area_Fisica");
            entity.Property(e => e.AreaTotal).HasColumnName("Area_Total");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArticulosTb>(entity =>
        {
            entity.HasKey(e => e.IdArticulo)
                .HasName("PK75")
                .IsClustered(false);

            entity.ToTable("Articulos_TB", "pd");

            entity.Property(e => e.IdArticulo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Articulo");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreArticulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Articulo");
            entity.Property(e => e.NumeroChasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Chasis");
            entity.Property(e => e.NumeroMotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Motor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CamasLoteVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Camas_Lote_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CamasLotesFisicosTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreLote, e.NumeroCama })
                .HasName("PK26_1")
                .IsClustered(false);

            entity.ToTable("Camas_Lotes_Fisicos_TB", "pd");

            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");

            entity.HasOne(d => d.NombreLoteNavigation).WithMany(p => p.CamasLotesFisicosTbs)
                .HasForeignKey(d => d.NombreLote)
                .HasConstraintName("RefLotes_Fisicos_TB217");
        });

        modelBuilder.Entity<CamasLotesPoTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote, e.NumeroCama })
                .HasName("PK26")
                .IsClustered(false);

            entity.ToTable("Camas_Lotes_PO_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");

            entity.HasOne(d => d.LotesPoTb).WithMany(p => p.CamasLotesPoTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .HasConstraintName("RefLotes_PO_TB85");
        });

        modelBuilder.Entity<CentroCostoTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreLote, e.SiembraNum, e.CentroCosto, e.Cultivo })
                .HasName("PK8")
                .IsClustered(false);

            entity.ToTable("Centro_Costo_TB", "pd");

            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.NombreLoteNavigation).WithMany(p => p.CentroCostoTbs)
                .HasForeignKey(d => d.NombreLote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLotes_Fisicos_TB11");
        });

        modelBuilder.Entity<CentroCostoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Centro_Costo_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
        });

        modelBuilder.Entity<CentroCostoVw1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CENTRO_COSTO_VW_1", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
        });

        modelBuilder.Entity<CertificacionesTb>(entity =>
        {
            entity.HasKey(e => new { e.IdProducto, e.NombreCertificacion })
                .HasName("PK29")
                .IsClustered(false);

            entity.ToTable("Certificaciones_TB", "pd");

            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreCertificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Certificacion");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DdtPrecosecha).HasColumnName("Ddt_Precosecha");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.CertificacionesTbs)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("RefProductos_TB121");
        });

        modelBuilder.Entity<CodigosTrazabilidadTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote })
                .HasName("PK95")
                .IsClustered(false);

            entity.ToTable("Codigos_Trazabilidad_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CodigosTrazabilidad)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Codigos_Trazabilidad");
        });

        modelBuilder.Entity<ConsultasTb>(entity =>
        {
            entity.HasKey(e => new { e.Departamento, e.NombreConsulta })
                .HasName("PK52")
                .IsClustered(false);

            entity.ToTable("Consultas_TB", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreConsulta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Consulta");
            entity.Property(e => e.Comando)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.ConsultasTbs)
                .HasForeignKey(d => d.Departamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefDepartamento_TB163");
        });

        modelBuilder.Entity<ControlUsuarioTb>(entity =>
        {
            entity.HasKey(e => new { e.ControlDeniega, e.Usuario })
                .HasName("PK84")
                .IsClustered(false);

            entity.ToTable("Control_Usuario_TB", "pd");

            entity.Property(e => e.ControlDeniega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Control_Deniega");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.ControlUsuarioTbs)
                .HasForeignKey(d => d.Usuario)
                .HasConstraintName("RefUsuario_TB203");
        });

        modelBuilder.Entity<CultivoProductoFaseTb>(entity =>
        {
            entity.HasKey(e => new { e.Cultivo, e.ProductoTipoUso })
                .HasName("PK58")
                .IsClustered(false);

            entity.ToTable("Cultivo_Producto_Fase_TB", "pd");

            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductoTipoUso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Producto_Tipo_Uso");
            entity.Property(e => e.CodigoFase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_Fase");
        });

        modelBuilder.Entity<DdtLaborTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNumero, e.Departamento, e.Labor, e.AliasLabor, e.Ddt })
                .HasName("PK21")
                .IsClustered(false);

            entity.ToTable("DDT_Labor_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNumero).HasColumnName("Siembra_Numero");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.DdtLaborTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB81");

            entity.HasOne(d => d.LaborTTb).WithMany(p => p.DdtLaborTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNumero, d.Departamento, d.Labor, d.AliasLabor })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLabor_T_TB52");
        });

        modelBuilder.Entity<DepartamentoTb>(entity =>
        {
            entity.HasKey(e => e.Departamento)
                .HasName("PK19")
                .IsClustered(false);

            entity.ToTable("Departamento_TB", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Encargado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepartamentosConPedidosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Departamentos_Con_Pedidos_VW", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntregaProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdEntrega, e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK60")
                .IsClustered(false);

            entity.ToTable("Entrega_Producto_TB", "pd");

            entity.Property(e => e.IdEntrega)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Entrega");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraEntraga).HasColumnName("Fecha_Hora_Entraga");
            entity.Property(e => e.IdEmpleadoEntraga)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Entraga");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.KnPoPedidoProductosTb).WithMany(p => p.EntregaProductoTbs)
                .HasForeignKey(d => new { d.IdPedido, d.IdProducto, d.NumBoleta })
                .HasConstraintName("RefKN_PO_Pedido_Productos_TB170");
        });

        modelBuilder.Entity<EstRangosPesosTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreRango, e.Temporada })
                .HasName("PK16")
                .IsClustered(false);

            entity.ToTable("EST_Rangos_Pesos_TB", "pd");

            entity.Property(e => e.NombreRango)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Rango");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MayorIgualQue).HasColumnName("Mayor_Igual_Que");
            entity.Property(e => e.MenorQue).HasColumnName("Menor_Que");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.EstRangosPesosTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB209");
        });

        modelBuilder.Entity<EstSemanaTb>(entity =>
        {
            entity.HasKey(e => new { e.NumeroSemana, e.Temporada })
                .HasName("PK18")
                .IsClustered(false);

            entity.ToTable("EST_Semana_TB", "pd");

            entity.Property(e => e.NumeroSemana).HasColumnName("Numero_Semana");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.EstSemanaTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB206");
        });

        modelBuilder.Entity<FechaCosechaMinVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fecha_Cosecha_Min_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.FechaCosecha).HasColumnName("Fecha_Cosecha");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FechaTb>(entity =>
        {
            entity.HasKey(e => e.Fecha)
                .HasName("PK91")
                .IsClustered(false);

            entity.ToTable("Fecha_TB", "pd");
        });

        modelBuilder.Entity<FtAplicacionesTb>(entity =>
        {
            entity.HasKey(e => new { e.IdAplicacion, e.IdTaplicacion, e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote, e.IdTractor, e.IdSpray })
                .HasName("PK79")
                .IsClustered(false);

            entity.ToTable("FT_Aplicaciones_TB", "pd");

            entity.Property(e => e.IdAplicacion)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Aplicacion");
            entity.Property(e => e.IdTaplicacion).HasColumnName("ID_TAplicacion");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.IdTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Tractor");
            entity.Property(e => e.IdSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Spray");
            entity.Property(e => e.CentroLlenado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Centro_Llenado");
            entity.Property(e => e.FechaHoraFin).HasColumnName("Fecha_Hora_Fin");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.IdHayudante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Hayudante");
            entity.Property(e => e.IdOperador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Operador");
            entity.Property(e => e.Marcha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreHayudante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Hayudante");
            entity.Property(e => e.NombreOperador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Operador");
            entity.Property(e => e.NombreSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Spray");
            entity.Property(e => e.NombreTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Tractor");
            entity.Property(e => e.PhLimpio).HasColumnName("PH_Limpio");
            entity.Property(e => e.PhMezcla).HasColumnName("PH_Mezcla");
            entity.Property(e => e.PresionSpray).HasColumnName("Presion_Spray");
            entity.Property(e => e.Rpm).HasColumnName("RPM");

            entity.HasOne(d => d.IdSprayNavigation).WithMany(p => p.FtAplicacionesTbIdSprayNavigations)
                .HasForeignKey(d => d.IdSpray)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefArticulos_TB201");

            entity.HasOne(d => d.IdTaplicacionNavigation).WithMany(p => p.FtAplicacionesTbs)
                .HasForeignKey(d => d.IdTaplicacion)
                .HasConstraintName("RefFT_Turno_Aplicacion_TB190");

            entity.HasOne(d => d.IdTractorNavigation).WithMany(p => p.FtAplicacionesTbIdTractorNavigations)
                .HasForeignKey(d => d.IdTractor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefArticulos_TB199");

            entity.HasOne(d => d.LotesPoTb).WithMany(p => p.FtAplicacionesTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .HasConstraintName("RefLotes_PO_TB188");
        });

        modelBuilder.Entity<FtApruebaProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.FtIdAprueba, e.NumBoleta })
                .HasName("PK63_1")
                .IsClustered(false);

            entity.ToTable("FT_Aprueba_Producto_TB", "pd");

            entity.Property(e => e.FtIdAprueba)
                .ValueGeneratedOnAdd()
                .HasColumnName("FT_ID_Aprueba");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.IdEmpleadoEjecuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Ejecuta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.NumBoletaNavigation).WithMany(p => p.FtApruebaProductoTbs)
                .HasForeignKey(d => d.NumBoleta)
                .HasConstraintName("RefFT_Pedido_TB183");
        });

        modelBuilder.Entity<FtApruebaProductoTbMaxFechaApruevaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Aprueba_Producto_TB_Max_Fecha_Aprueva_VW", "pd");

            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.IdEmpleadoAprueva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Aprueva");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");
        });

        modelBuilder.Entity<FtEntregaProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.FtIdEntrega, e.NumBoleta })
                .HasName("PK63_2")
                .IsClustered(false);

            entity.ToTable("FT_Entrega_Producto_TB", "pd");

            entity.Property(e => e.FtIdEntrega)
                .ValueGeneratedOnAdd()
                .HasColumnName("FT_ID_Entrega");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.IdEmpleadoEjecuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Ejecuta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.NumBoletaNavigation).WithMany(p => p.FtEntregaProductoTbs)
                .HasForeignKey(d => d.NumBoleta)
                .HasConstraintName("RefFT_Pedido_TB184");
        });

        modelBuilder.Entity<FtEstadoLarvaTb>(entity =>
        {
            entity.HasKey(e => new { e.IdMfruto, e.EstadoLarva })
                .HasName("PK72_1")
                .IsClustered(false);

            entity.ToTable("FT_Estado_Larva_TB", "pd");

            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.EstadoLarva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Larva");
            entity.Property(e => e.IdLarva)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_LARVA");
        });

        modelBuilder.Entity<FtEstadoLarvaTbDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Estado_Larva_TB_ddt_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CantidadPorPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Cantidad_Por_Punto");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.EstadoLarva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Larva");
            entity.Property(e => e.FechaHoraMonitoreo).HasColumnName("Fecha_Hora_Monitoreo");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtLarvasMasEstadoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Larvas_Mas_Estado_VW", "pd");

            entity.Property(e => e.CantidadDlarva).HasColumnName("Cantidad_DLarva");
            entity.Property(e => e.CantidadElarva).HasColumnName("Cantidad_ELarva");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoLarva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Larva");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.NombreDlarva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_DLarva");
        });

        modelBuilder.Entity<FtLarvasMonitoreoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdMfruto, e.NombreDlarva });

            entity.ToTable("FT_Larvas_Monitoreo_TB", "pd");

            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.NombreDlarva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_DLarva");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdLarva)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_LARVA");
        });

        modelBuilder.Entity<FtLarvasMonitoreoTbDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Larvas_Monitoreo_TB_ddt_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CantidadPorPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Cantidad_Por_Punto");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFechaHoraMonitoreo).HasColumnName("Fecha_Fecha_Hora_Monitoreo");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreDlarva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_DLarva");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoFrutoNombreEstadoDlarvaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Fruto_NombreEstado_DLarva_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CantidadDlarva).HasColumnName("Cantidad_DLarva");
            entity.Property(e => e.CantidadElarva).HasColumnName("Cantidad_ELarva");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DanosLeves).HasColumnName("Danos_Leves");
            entity.Property(e => e.DanosNuevos).HasColumnName("Danos_Nuevos");
            entity.Property(e => e.DanosSeveros).HasColumnName("Danos_Severos");
            entity.Property(e => e.DanosViejos).HasColumnName("Danos_Viejos");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoLarva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Larva");
            entity.Property(e => e.FrutosConLarva).HasColumnName("Frutos_Con_Larva");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreDlarva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_DLarva");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Obsrvaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoFrutoNombreEstadoDlarvaVwDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Fruto_NombreEstado_DLarva_VW_ddt_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaHibrido).HasColumnName("Area_Hibrido");
            entity.Property(e => e.CantidadDlarva).HasColumnName("Cantidad_DLarva");
            entity.Property(e => e.CantidadElarva).HasColumnName("Cantidad_ELarva");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DanosLeves).HasColumnName("Danos_Leves");
            entity.Property(e => e.DanosNuevos).HasColumnName("Danos_Nuevos");
            entity.Property(e => e.DanosSeveros).HasColumnName("Danos_Severos");
            entity.Property(e => e.DanosViejos).HasColumnName("Danos_Viejos");
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoLarva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Estado_Larva");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.FrutosConLarva).HasColumnName("Frutos_Con_Larva");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreDlarva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_DLarva");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Obsrvaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoFrutoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdMfruto, e.Temporada, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK72")
                .IsClustered(false);

            entity.ToTable("FT_Monitoreo_Fruto_TB", "pd");

            entity.Property(e => e.IdMfruto)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_MFruto");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.DanosLeves).HasColumnName("Danos_Leves");
            entity.Property(e => e.DanosNuevos).HasColumnName("Danos_Nuevos");
            entity.Property(e => e.DanosSeveros).HasColumnName("Danos_Severos");
            entity.Property(e => e.DanosViejos).HasColumnName("Danos_Viejos");
            entity.Property(e => e.FrutosConLarva).HasColumnName("Frutos_Con_Larva");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.Obsrvaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");

            entity.HasOne(d => d.LvTermporadaTb).WithMany(p => p.FtMonitoreoFrutoTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.Tratamiento, d.NombreLote, d.AliasLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLV_Termporada_TB186");
        });

        modelBuilder.Entity<FtMonitoreoFrutoTbDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Fruto_TB_ddt_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DanosLeves).HasColumnName("Danos_Leves");
            entity.Property(e => e.DanosNuevos).HasColumnName("Danos_Nuevos");
            entity.Property(e => e.DanosSeveros).HasColumnName("Danos_Severos");
            entity.Property(e => e.DanosViejos).HasColumnName("Danos_Viejos");
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.FechaHoraMonitoreo).HasColumnName("Fecha_Hora_Monitoreo");
            entity.Property(e => e.FrutosConLarva).HasColumnName("Frutos_Con_Larva");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Obsrvaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoFrutoTbDdtVwHa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Fruto_TB_ddt_VW_Ha", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DanosLeves).HasColumnName("Danos_Leves");
            entity.Property(e => e.DanosLevesHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Danos_Leves_Ha");
            entity.Property(e => e.DanosNuevos).HasColumnName("Danos_Nuevos");
            entity.Property(e => e.DanosNuevosHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Danos_Nuevos_Ha");
            entity.Property(e => e.DanosSeveros).HasColumnName("Danos_Severos");
            entity.Property(e => e.DanosSeverosHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Danos_Severos_Ha");
            entity.Property(e => e.DanosTotales).HasColumnName("Danos_Totales");
            entity.Property(e => e.DanosTotalesHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Danos_Totales_Ha");
            entity.Property(e => e.DanosViejos).HasColumnName("Danos_Viejos");
            entity.Property(e => e.DanosViejosHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Danos_Viejos_Ha");
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.FechaHoraMonitoreo).HasColumnName("Fecha_Hora_Monitoreo");
            entity.Property(e => e.FrutosConLarva).HasColumnName("Frutos_Con_Larva");
            entity.Property(e => e.FrutosConLarvasHa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Frutos_Con_Larvas_Ha");
            entity.Property(e => e.FrutosMetro)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Frutos_Metro");
            entity.Property(e => e.FrutosMonitoreo).HasColumnName("Frutos_Monitoreo");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMfruto).HasColumnName("ID_MFruto");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.MetrosMonitoreo).HasColumnName("Metros_Monitoreo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Obsrvaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PdanosLeves)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PDanos_Leves");
            entity.Property(e => e.PdanosNuevos)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PDanos_Nuevos");
            entity.Property(e => e.PdanosSeveros)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PDanos_Severos");
            entity.Property(e => e.PdanosTotales)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PDanos_Totales");
            entity.Property(e => e.PdanosViejos)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PDanos_Viejos");
            entity.Property(e => e.PfrutosConLarvas)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PFrutos_Con_Larvas");
            entity.Property(e => e.PfrutosSinLarvas)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PFrutos_Sin_Larvas");
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreo).HasColumnName("Puntos_Monitoreo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoPlagasTb>(entity =>
        {
            entity.HasKey(e => new { e.IdMplagas, e.Temporada, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK71")
                .IsClustered(false);

            entity.ToTable("FT_Monitoreo_Plagas_TB", "pd");

            entity.Property(e => e.IdMplagas)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_MPlagas");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AfidosAlados).HasColumnName("Afidos_Alados");
            entity.Property(e => e.AfidosCol).HasColumnName("Afidos_Col");
            entity.Property(e => e.AfidosTotal)
                .HasComputedColumnSql("([Afidos_Alados]+[Afidos_Col])", false)
                .HasColumnName("Afidos_Total");
            entity.Property(e => e.DiafaniaHuevo).HasColumnName("Diafania_Huevo");
            entity.Property(e => e.DiafaniaLarva).HasColumnName("Diafania_Larva");
            entity.Property(e => e.DiafaniaTotal)
                .HasComputedColumnSql("([Diafania_Larva]+[Diafania_Huevo])", false)
                .HasColumnName("Diafania_Total");
            entity.Property(e => e.FechaHoraMuestreo).HasColumnName("Fecha_Hora_Muestreo");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.LfrutoDiafania).HasColumnName("LFruto_Diafania");
            entity.Property(e => e.LfrutoSpodoptera).HasColumnName("LFruto_Spodoptera");
            entity.Property(e => e.LfrutoTotal)
                .HasComputedColumnSql("([LFruto_Diafania]+[LFruto_Spodoptera])", false)
                .HasColumnName("LFruto_Total");
            entity.Property(e => e.MetrosMontoreos).HasColumnName("Metros_Montoreos");
            entity.Property(e => e.MinadorAdulto).HasColumnName("Minador_Adulto");
            entity.Property(e => e.MinadorEdlL1).HasColumnName("Minador_EDL_L1");
            entity.Property(e => e.MinadorEdlL2).HasColumnName("Minador_EDL_L2");
            entity.Property(e => e.MinadorEdlL3).HasColumnName("Minador_EDL_L3");
            entity.Property(e => e.MinadorTotal)
                .HasComputedColumnSql("((([Minador_Adulto]+[Minador_EDL_L1])+[Minador_EDL_L2])+[Minador_EDL_L3])", false)
                .HasColumnName("Minador_Total");
            entity.Property(e => e.MoscaBlancaTtales).HasColumnName("Mosca_Blanca_Ttales");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PlagasTotal)
                .HasComputedColumnSql("((((((((((((([Minador_Adulto]+[Minador_EDL_L1])+[Minador_EDL_L2])+[Minador_EDL_L3])+[Afidos_Alados])+[Afidos_Col])+[Diafania_Larva])+[Diafania_Huevo])+[Spodoptera_Larva])+[Spodoptera_Huevo])+[LFruto_Diafania])+[LFruto_Spodoptera])+[Trips])+[Mosca_Blanca_Ttales])", false)
                .HasColumnName("Plagas_Total");
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreos).HasColumnName("Puntos_Monitoreos");
            entity.Property(e => e.SpodopteraHuevo).HasColumnName("Spodoptera_Huevo");
            entity.Property(e => e.SpodopteraLarva).HasColumnName("Spodoptera_Larva");
            entity.Property(e => e.SpodopteraTotal)
                .HasComputedColumnSql("([Spodoptera_Larva]+[Spodoptera_Huevo])", false)
                .HasColumnName("Spodoptera_Total");

            entity.HasOne(d => d.LvTermporadaTb).WithMany(p => p.FtMonitoreoPlagasTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.Tratamiento, d.NombreLote, d.AliasLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLV_Termporada_TB179");
        });

        modelBuilder.Entity<FtMonitoreoPlagasTbDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Plagas_TB_ddt_VW", "pd");

            entity.Property(e => e.AfidosAlados).HasColumnName("Afidos_Alados");
            entity.Property(e => e.AfidosCol).HasColumnName("Afidos_Col");
            entity.Property(e => e.AfidosTotal).HasColumnName("Afidos_Total");
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaHibrido).HasColumnName("Area_Hibrido");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.DiafaniaHuevo).HasColumnName("Diafania_Huevo");
            entity.Property(e => e.DiafaniaLarva).HasColumnName("Diafania_Larva");
            entity.Property(e => e.DiafaniaTotal).HasColumnName("Diafania_Total");
            entity.Property(e => e.FechaHoraMuestreo).HasColumnName("Fecha_Hora_Muestreo");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMplagas).HasColumnName("ID_MPlagas");
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.LfrutoDiafania).HasColumnName("LFruto_Diafania");
            entity.Property(e => e.LfrutoSpodoptera).HasColumnName("LFruto_Spodoptera");
            entity.Property(e => e.LfrutoTotal).HasColumnName("LFruto_Total");
            entity.Property(e => e.MetrosMontoreos).HasColumnName("Metros_Montoreos");
            entity.Property(e => e.MinadorAdulto).HasColumnName("Minador_Adulto");
            entity.Property(e => e.MinadorEdlL1).HasColumnName("Minador_EDL_L1");
            entity.Property(e => e.MinadorEdlL2).HasColumnName("Minador_EDL_L2");
            entity.Property(e => e.MinadorEdlL3).HasColumnName("Minador_EDL_L3");
            entity.Property(e => e.MinadorTotal).HasColumnName("Minador_Total");
            entity.Property(e => e.MoscaBlancaTotal).HasColumnName("Mosca_Blanca_Total");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PlagasTotal).HasColumnName("Plagas_Total");
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreos).HasColumnName("Puntos_Monitoreos");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.SpodopteraHuevo).HasColumnName("Spodoptera_Huevo");
            entity.Property(e => e.SpodopteraLarva).HasColumnName("Spodoptera_Larva");
            entity.Property(e => e.SpodopteraTotal).HasColumnName("Spodoptera_Total");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoPlagasTbDdtVw1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Plagas_TB_ddt_VW_1", "pd");

            entity.Property(e => e.AfidosAladosPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Afidos_Alados_Punto");
            entity.Property(e => e.AfidosColPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Afidos_Col_Punto");
            entity.Property(e => e.AfidosTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Afidos_Total_Punto");
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaHibrido).HasColumnName("Area_Hibrido");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.DiafaniaHuevoPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Diafania_Huevo_Punto");
            entity.Property(e => e.DiafaniaLarvaPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Diafania_Larva_Punto");
            entity.Property(e => e.DiafaniaTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Diafania_Total_Punto");
            entity.Property(e => e.FechaHoraMuestreo).HasColumnName("Fecha_Hora_Muestreo");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdMplagas).HasColumnName("ID_MPlagas");
            entity.Property(e => e.LfrutoDiafaniaPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LFruto_Diafania_Punto");
            entity.Property(e => e.LfrutoSpodopteraPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LFruto_Spodoptera_Punto");
            entity.Property(e => e.LfrutoTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LFruto_Total_Punto");
            entity.Property(e => e.MetrosMontoreos).HasColumnName("Metros_Montoreos");
            entity.Property(e => e.MinadorAdultoPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Minador_Adulto_Punto");
            entity.Property(e => e.MinadorEdlL1Punto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Minador_EDL_L1_Punto");
            entity.Property(e => e.MinadorEdlL2Punto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Minador_EDL_L2_Punto");
            entity.Property(e => e.MinadorEdlL3Punto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Minador_EDL_L3_Punto");
            entity.Property(e => e.MinadorTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Minador_Total_Punto");
            entity.Property(e => e.MoscaBlancaTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Mosca_Blanca_Total_Punto");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PlagasTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Plagas_Total_Punto");
            entity.Property(e => e.PuntosMonitoreos).HasColumnName("Puntos_Monitoreos");
            entity.Property(e => e.PupaPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Pupa_Punto");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.SpodopteraHuevoPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Spodoptera_Huevo_Punto");
            entity.Property(e => e.SpodopteraLarvaPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Spodoptera_Larva_Punto");
            entity.Property(e => e.SpodopteraTotalPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Spodoptera_Total_Punto");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TripsPunto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Trips_Punto");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMonitoreoPlagasVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Monitoreo_Plagas_VW", "pd");

            entity.Property(e => e.AfidosAlados).HasColumnName("Afidos_Alados");
            entity.Property(e => e.AfidosCol).HasColumnName("Afidos_Col");
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiafaniaHuevo).HasColumnName("Diafania_Huevo");
            entity.Property(e => e.DiafaniaLarva).HasColumnName("Diafania_Larva");
            entity.Property(e => e.FechaHoraMuestreo).HasColumnName("Fecha_Hora_Muestreo");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlaguero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Plaguero");
            entity.Property(e => e.LfrutoDiafania).HasColumnName("LFruto_Diafania");
            entity.Property(e => e.LfrutoSpodoptera).HasColumnName("LFruto_Spodoptera");
            entity.Property(e => e.MetrosMontoreos).HasColumnName("Metros_Montoreos");
            entity.Property(e => e.MinadorAdulto).HasColumnName("Minador_Adulto");
            entity.Property(e => e.MinadorEdlL1).HasColumnName("Minador_EDL_L1");
            entity.Property(e => e.MinadorEdlL2).HasColumnName("Minador_EDL_L2");
            entity.Property(e => e.MinadorEdlL3).HasColumnName("Minador_EDL_L3");
            entity.Property(e => e.MoscaBlancaTtales).HasColumnName("Mosca_Blanca_Ttales");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Plaguero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntosMonitoreos).HasColumnName("Puntos_Monitoreos");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.SpodopteraHuevo).HasColumnName("Spodoptera_Huevo");
            entity.Property(e => e.SpodopteraLarva).HasColumnName("Spodoptera_Larva");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtMotivoPedidoProductosMaxFrecuenciaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Motivo_Pedido_Productos_Max_Frecuencia_VW", "pd");

            entity.Property(e => e.FrecuenciaUsoMax).HasColumnName("Frecuencia_Uso_Max");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
        });

        modelBuilder.Entity<FtMotivoPedidoProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Motivo_Pedido_Productos_VW", "pd");

            entity.Property(e => e.FrecuenciaUso).HasColumnName("Frecuencia_Uso");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.MotivoPaplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_PAplicacion");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
        });

        modelBuilder.Entity<FtPedidoProductosCertificacionVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Pedido_Productos_Certificacion_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.ConcentracionIactivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concentracion_IActivo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DdtPrecosecha).HasColumnName("Ddt_Precosecha");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.IngredienteActivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingrediente_Activo");
            entity.Property(e => e.MotivoPaplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_PAplicacion");
            entity.Property(e => e.NombreCertificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Certificacion");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RestriccionIngreso).HasColumnName("Restriccion_Ingreso");
            entity.Property(e => e.Rmezclero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RMezclero");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<FtPedidoProductosTb>(entity =>
        {
            entity.HasKey(e => new { e.NumBoleta, e.IdProducto })
                .HasName("PK70")
                .IsClustered(false);

            entity.ToTable("FT_Pedido_Productos_TB", "pd");

            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.MotivoPaplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_PAplicacion");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.FtPedidoProductosTbs)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefProductos_TB182");

            entity.HasOne(d => d.NumBoletaNavigation).WithMany(p => p.FtPedidoProductosTbs)
                .HasForeignKey(d => d.NumBoleta)
                .HasConstraintName("RefFT_Pedido_TB181");
        });

        modelBuilder.Entity<FtPedidoProductosTrazabilidadHibridosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Pedido_Productos_Trazabilidad_Hibridos_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CodigosTrazabilidad)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Codigos_Trazabilidad");
            entity.Property(e => e.ConcentracionIactivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concentracion_IActivo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DdtPrecosecha).HasColumnName("Ddt_Precosecha");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaCosecha).HasColumnName("Fecha_Cosecha");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.IngredienteActivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingrediente_Activo");
            entity.Property(e => e.MotivoPaplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_PAplicacion");
            entity.Property(e => e.NombreCertificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Certificacion");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RestriccionIngreso).HasColumnName("Restriccion_Ingreso");
            entity.Property(e => e.Rmezclero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RMezclero");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TodosLosHibridos)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Todos_LosHibridos");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<FtPedidoProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Pedido_Productos_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.MotivoPaplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_PAplicacion");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rmezclero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RMezclero");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<FtPedidoProductosVw1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Pedido_Productos_VW_1", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entrega)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Rdistribuidor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuidor");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPor1Cargas).HasColumnName("Unidades_Por_1_Cargas");
            entity.Property(e => e.UnidadesPorCargasDesimales).HasColumnName("Unidades_Por_Cargas_Desimales");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<FtPedidoProductosVw2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Pedido_Productos_VW_2", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CodigoFase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_Fase");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entrega)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Rdistribuidor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuidor");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPor1Cargas).HasColumnName("Unidades_Por_1_Cargas");
            entity.Property(e => e.UnidadesPorCargasDesimales).HasColumnName("Unidades_Por_Cargas_Desimales");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<FtPedidoTb>(entity =>
        {
            entity.HasKey(e => e.NumBoleta)
                .HasName("PK63")
                .IsClustered(false);

            entity.ToTable("FT_Pedido_TB", "pd");

            entity.Property(e => e.NumBoleta)
                .ValueGeneratedNever()
                .HasColumnName("Num_Boleta");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.NumCargas).HasColumnName("Num_Cargas");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rmezclero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RMezclero");
            entity.Property(e => e.SiembraNum)
                .HasDefaultValue(-1)
                .HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtRdistribuidorProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.FtIdRmezclero, e.NumBoleta })
                .HasName("PK63_3")
                .IsClustered(false);

            entity.ToTable("FT_RDistribuidor_Producto_TB", "pd");

            entity.Property(e => e.FtIdRmezclero)
                .ValueGeneratedOnAdd()
                .HasColumnName("FT_ID_RMezclero");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraEjecuta).HasColumnName("Fecha_Hora_Ejecuta");
            entity.Property(e => e.IdEmpleadoEjecuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Ejecuta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.NumBoletaNavigation).WithMany(p => p.FtRdistribuidorProductoTbs)
                .HasForeignKey(d => d.NumBoleta)
                .HasConstraintName("RefFT_Pedido_TB185");
        });

        modelBuilder.Entity<FtTurnoAplicacionTb>(entity =>
        {
            entity.HasKey(e => e.IdTaplicacion)
                .HasName("PK78")
                .IsClustered(false);

            entity.ToTable("FT_Turno_Aplicacion_TB", "pd");

            entity.Property(e => e.IdTaplicacion).HasColumnName("ID_TAplicacion");
            entity.Property(e => e.FechaHoraEntrada).HasColumnName("Fecha_Hora_Entrada");
            entity.Property(e => e.FechaHoraSalida).HasColumnName("Fecha_Hora_Salida");
            entity.Property(e => e.IdRevisadoPor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Revisado_Por");
            entity.Property(e => e.IdSupervisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Supervisor");
            entity.Property(e => e.NombreRevisadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Revisado_Por");
            entity.Property(e => e.NombreSupervisor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Supervisor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FtTurnoMasAplicacionesDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Turno_Mas_Aplicaciones_ddt_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CentroLlenado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Centro_Llenado");
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.FechaHoraFin).HasColumnName("Fecha_Hora_Fin");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.IdAyudante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Ayudante");
            entity.Property(e => e.IdOperador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Operador");
            entity.Property(e => e.IdRevisadoPor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Revisado_Por");
            entity.Property(e => e.IdSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Spray");
            entity.Property(e => e.IdSupervisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Supervisor");
            entity.Property(e => e.IdTaplicacion).HasColumnName("ID_TAplicacion");
            entity.Property(e => e.IdTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Tractor");
            entity.Property(e => e.Marcha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreAyudante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Ayudante");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreOperador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Operador");
            entity.Property(e => e.NombreRevisadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Revisado_Por");
            entity.Property(e => e.NombreSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Spray");
            entity.Property(e => e.NombreSupervisor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Supervisor");
            entity.Property(e => e.NombreTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Tractor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhLimpio).HasColumnName("PH_Limpio");
            entity.Property(e => e.PhMezcla).HasColumnName("PH_Mezcla");
            entity.Property(e => e.PresionSpray).HasColumnName("Presion_Spray");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TurnoFechaHoraEntrada).HasColumnName("Turno_Fecha_Hora_Entrada");
            entity.Property(e => e.TurnoFechaHoraSalida).HasColumnName("Turno_Fecha_Hora_Salida");
        });

        modelBuilder.Entity<FtTurnoMasAplicacionesDdtVwMetereologiaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FT_Turno_Mas_Aplicaciones_ddt_VW_Metereologia_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CentroLlenado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Centro_Llenado");
            entity.Property(e => e.Ddt).HasColumnName("ddt");
            entity.Property(e => e.FechaHoraFin).HasColumnName("Fecha_Hora_Fin");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.HumedadRelativa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Humedad_Relativa");
            entity.Property(e => e.IdAyudante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Ayudante");
            entity.Property(e => e.IdOperador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Operador");
            entity.Property(e => e.IdRevisadoPor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Revisado_Por");
            entity.Property(e => e.IdSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Spray");
            entity.Property(e => e.IdSupervisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Supervisor");
            entity.Property(e => e.IdTaplicacion).HasColumnName("ID_TAplicacion");
            entity.Property(e => e.IdTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Tractor");
            entity.Property(e => e.Marcha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreAyudante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Ayudante");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreOperador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Operador");
            entity.Property(e => e.NombreRevisadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Revisado_Por");
            entity.Property(e => e.NombreSpray)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Spray");
            entity.Property(e => e.NombreSupervisor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Supervisor");
            entity.Property(e => e.NombreTractor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Tractor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhLimpio).HasColumnName("PH_Limpio");
            entity.Property(e => e.PhMezcla).HasColumnName("PH_Mezcla");
            entity.Property(e => e.Piranometro).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Precipitacion).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PresionSpray).HasColumnName("Presion_Spray");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temperatura).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TurnoFechaHoraEntrada).HasColumnName("Turno_Fecha_Hora_Entrada");
            entity.Property(e => e.TurnoFechaHoraSalida).HasColumnName("Turno_Fecha_Hora_Salida");
            entity.Property(e => e.VelocidadViento)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("Velocidad_Viento");
        });

        modelBuilder.Entity<HibridosPoTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.Tratamiento, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK5")
                .IsClustered(false);

            entity.ToTable("Hibridos_PO_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.HibridosPoTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB29");

            entity.HasOne(d => d.VariedadTb).WithMany(p => p.HibridosPoTbs)
                .HasForeignKey(d => new { d.Cultivo, d.Variedad })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefVariedad_TB49");

            entity.HasOne(d => d.HibridosTb).WithMany(p => p.HibridosPoTbs)
                .HasForeignKey(d => new { d.Cultivo, d.Variedad, d.Hibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefHibridos_TB19");
        });

        modelBuilder.Entity<HibridosTb>(entity =>
        {
            entity.HasKey(e => new { e.Cultivo, e.Variedad, e.Hibrido })
                .HasName("PK6")
                .IsClustered(false);

            entity.ToTable("Hibridos_TB", "pd");

            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Identificador)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.VariedadTb).WithMany(p => p.HibridosTbs)
                .HasForeignKey(d => new { d.Cultivo, d.Variedad })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefVariedad_TB18");
        });

        modelBuilder.Entity<HorasRiegoTb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Horas_Riego_TB", "pd");

            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Cabezal)
                .HasMaxLength(50)
                .HasColumnName("cabezal");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .HasColumnName("cultivo");
            entity.Property(e => e.FechaRiego).HasColumnName("fecha_riego");
            entity.Property(e => e.HorasRiego).HasColumnName("horas_riego");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasColumnName("lote");
            entity.Property(e => e.Mes)
                .HasComputedColumnSql("(datepart(month,[fecha_riego]))", false)
                .HasColumnName("_Mes");
        });

        modelBuilder.Entity<KnAjusteAzucarTb>(entity =>
        {
            entity.HasKey(e => new { e.Safra, e.AjusteAzucar })
                .HasName("PK53")
                .IsClustered(false);

            entity.ToTable("KN_Ajuste_Azucar_TB", "pd");

            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AjusteAzucar).HasColumnName("Ajuste_Azucar");
            entity.Property(e => e.FechaAjuste).HasColumnName("Fecha_Ajuste");
        });

        modelBuilder.Entity<KnAjusteMielTb>(entity =>
        {
            entity.HasKey(e => new { e.Safra, e.AjusteMiel })
                .HasName("PK54")
                .IsClustered(false);

            entity.ToTable("KN_Ajuste_Miel_TB", "pd");

            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AjusteMiel).HasColumnName("Ajuste_Miel");
            entity.Property(e => e.FechaAjuste).HasColumnName("Fecha_Ajuste");
        });

        modelBuilder.Entity<KnCamionesDiaTurnoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Camiones_Dia_Turno_VW", "pd");

            entity.Property(e => e.DiaDeCorta).HasColumnName("Dia_De_Corta");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnCortaCanaTb>(entity =>
        {
            entity.HasKey(e => new { e.NumCorta, e.FechaSiembra, e.NombreLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasLote })
                .HasName("PK34")
                .IsClustered(false);

            entity.ToTable("KN_Corta_Cana_TB", "pd");

            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.CortaMecanica)
                .HasDefaultValue(true)
                .HasColumnName("Corta_Mecanica");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quemado).HasDefaultValue(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.KnLotesCanaTb).WithMany(p => p.KnCortaCanaTbs)
                .HasForeignKey(d => new { d.FechaSiembra, d.Cultivo, d.Variedad, d.Hibrido, d.NombreLote, d.AliasLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefKN_Lotes_Cana_TB133");
        });

        modelBuilder.Entity<KnDatosPorTurnoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Datos_Por_Turno_VW", "pd");

            entity.Property(e => e.DiaDeCorta).HasColumnName("Dia_De_Corta");
            entity.Property(e => e.NetoExpPromedioPcamion).HasColumnName("Neto_Exp_Promedio_PCamion");
            entity.Property(e => e.PesoNApagarIngenioPromedioPcamion).HasColumnName("Peso_N_Apagar_Ingenio_Promedio_PCamion");
            entity.Property(e => e.PesoNIngenioPromedioPcamion).HasColumnName("Peso_N_Ingenio_Promedio_PCamion");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SumAzucar).HasColumnName("Sum_Azucar");
            entity.Property(e => e.SumAzucarC).HasColumnName("Sum_Azucar_c");
            entity.Property(e => e.SumBrix).HasColumnName("Sum_Brix");
            entity.Property(e => e.SumCastigoC).HasColumnName("Sum_Castigo_c");
            entity.Property(e => e.SumDiferenciaC).HasColumnName("Sum_Diferencia_c");
            entity.Property(e => e.SumMiel).HasColumnName("Sum_Miel");
            entity.Property(e => e.SumMielC).HasColumnName("Sum_Miel_c");
            entity.Property(e => e.SumNetoExp).HasColumnName("Sum_Neto_Exp");
            entity.Property(e => e.SumPesoNApagarIngenio).HasColumnName("Sum_Peso_N_Apagar_Ingenio");
            entity.Property(e => e.SumPesoNIngenio).HasColumnName("Sum_Peso_N_Ingenio");
            entity.Property(e => e.SumPol).HasColumnName("Sum_Pol");
            entity.Property(e => e.SumPureza).HasColumnName("Sum_Pureza");
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnDdtLaborTb>(entity =>
        {
            entity.HasKey(e => new { e.Departamento, e.Labor, e.AliasLabor, e.Ddt })
                .HasName("PK38")
                .IsClustered(false);

            entity.ToTable("KN_Ddt_Labor_TB", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");

            entity.HasOne(d => d.KnLaboresLotesTb).WithMany(p => p.KnDdtLaborTbs)
                .HasForeignKey(d => new { d.Departamento, d.Labor, d.AliasLabor })
                .HasConstraintName("RefKN_Labores_Lotes_TB147");
        });

        modelBuilder.Entity<KnDiaTurnoSumasVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Dia_Turno_Sumas_VW", "pd");

            entity.Property(e => e.DiaDeCorta).HasColumnName("Dia_De_Corta");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SumAzucar).HasColumnName("Sum_Azucar");
            entity.Property(e => e.SumAzucarC).HasColumnName("Sum_Azucar_c");
            entity.Property(e => e.SumBrix).HasColumnName("Sum_Brix");
            entity.Property(e => e.SumCastigoC).HasColumnName("Sum_Castigo_c");
            entity.Property(e => e.SumDiferenciaC).HasColumnName("Sum_Diferencia_c");
            entity.Property(e => e.SumMiel).HasColumnName("Sum_Miel");
            entity.Property(e => e.SumMielC).HasColumnName("Sum_Miel_c");
            entity.Property(e => e.SumNetoExp).HasColumnName("Sum_Neto_Exp");
            entity.Property(e => e.SumPesoNApagarIngenio).HasColumnName("Sum_Peso_N_Apagar_Ingenio");
            entity.Property(e => e.SumPesoNIngenio).HasColumnName("Sum_Peso_N_Ingenio");
            entity.Property(e => e.SumPol).HasColumnName("Sum_Pol");
            entity.Property(e => e.SumPureza).HasColumnName("Sum_Pureza");
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLaboresDdtProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Labores_Ddt_Productos_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<KnLaboresLotesTb>(entity =>
        {
            entity.HasKey(e => new { e.Departamento, e.Labor, e.AliasLabor })
                .HasName("PK39")
                .IsClustered(false);

            entity.ToTable("KN_Labores_Lotes_TB", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("TODO")
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo)
                .HasDefaultValue(true)
                .HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.KnLaboresLotesTbs)
                .HasForeignKey(d => d.Departamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefDepartamento_TB146");

            entity.HasOne(d => d.LaboresTb).WithMany(p => p.KnLaboresLotesTbs)
                .HasForeignKey(d => new { d.Labor, d.Departamento })
                .HasConstraintName("RefLabores_TB142");
        });

        modelBuilder.Entity<KnLotesCanaPlantaSocaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Cana_Planta_Soca_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCanaTb>(entity =>
        {
            entity.HasKey(e => new { e.FechaSiembra, e.Cultivo, e.Variedad, e.Hibrido, e.NombreLote, e.AliasLote })
                .HasName("PK31")
                .IsClustered(false);

            entity.ToTable("KN_Lotes_Cana_TB", "pd");

            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Renovado).HasDefaultValue(false);

            entity.HasOne(d => d.NombreLoteNavigation).WithMany(p => p.KnLotesCanaTbs)
                .HasForeignKey(d => d.NombreLote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLotes_Fisicos_TB125");

            entity.HasOne(d => d.HibridosTb).WithMany(p => p.KnLotesCanaTbs)
                .HasForeignKey(d => new { d.Cultivo, d.Variedad, d.Hibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefHibridos_TB129");
        });

        modelBuilder.Entity<KnLotesCanaTbCortaNumVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Cana_TB_Corta_Num_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UltimaCorta).HasColumnName("Ultima_Corta");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas0AjusteAzucarMielVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_0_Ajuste_Azucar_Miel_VW", "pd");

            entity.Property(e => e.AjusteAzucar).HasColumnName("Ajuste_Azucar");
            entity.Property(e => e.AjusteMiel).HasColumnName("Ajuste_Miel");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarC).HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC).HasColumnName("Castigo_c");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiferenciaC).HasColumnName("Diferencia_c");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielC).HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp).HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas0AjusteAzucarVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_0_Ajuste_Azucar_VW", "pd");

            entity.Property(e => e.AjusteAzucar).HasColumnName("Ajuste_Azucar");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarC).HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC).HasColumnName("Castigo_c");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiferenciaC).HasColumnName("Diferencia_c");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielC).HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp).HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas0AjusteMielVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_0_Ajuste_Miel_VW", "pd");

            entity.Property(e => e.AjusteMiel).HasColumnName("Ajuste_Miel");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarC).HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC).HasColumnName("Castigo_c");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiferenciaC).HasColumnName("Diferencia_c");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielC).HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp).HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas0RoundVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_0_Round_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarC).HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC).HasColumnName("Castigo_c");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiferenciaC).HasColumnName("Diferencia_c");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielC).HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp).HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas0Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_0_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarC).HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC).HasColumnName("Castigo_c");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiferenciaC).HasColumnName("Diferencia_c");
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicial).HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielC).HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp).HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas1RoundVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_1_Round_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarKgTonL).HasColumnName("Azucar_Kg_Ton_L");
            entity.Property(e => e.AzucarL).HasColumnName("Azucar_L");
            entity.Property(e => e.AzucarMasAjusteL).HasColumnName("Azucar_Mas_Ajuste_L");
            entity.Property(e => e.BrixL).HasColumnName("Brix_L");
            entity.Property(e => e.BrutoExpL).HasColumnName("Bruto_Exp_L");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielKgTonL).HasColumnName("Miel_Kg_Ton_L");
            entity.Property(e => e.MielL).HasColumnName("Miel_L");
            entity.Property(e => e.MielMasAjusteL).HasColumnName("Miel_Mas_Ajuste_L");
            entity.Property(e => e.NetoExpL).HasColumnName("Neto_Exp_L");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.PesoBIngenioL).HasColumnName("Peso_B_Ingenio_L");
            entity.Property(e => e.PesoNIngenioL).HasColumnName("Peso_N_Ingenio_L");
            entity.Property(e => e.PolL).HasColumnName("Pol_L");
            entity.Property(e => e.PurezaL).HasColumnName("Pureza_L");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExpL).HasColumnName("Tara_Exp_L");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas1Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_1_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AzucarKgTonL).HasColumnName("Azucar_Kg_Ton_L");
            entity.Property(e => e.AzucarL).HasColumnName("Azucar_L");
            entity.Property(e => e.AzucarMasAjusteL).HasColumnName("Azucar_Mas_Ajuste_L");
            entity.Property(e => e.BrixL).HasColumnName("Brix_L");
            entity.Property(e => e.BrutoExpL).HasColumnName("Bruto_Exp_L");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MielKgTonL).HasColumnName("Miel_Kg_Ton_L");
            entity.Property(e => e.MielL).HasColumnName("Miel_L");
            entity.Property(e => e.MielMasAjusteL).HasColumnName("Miel_Mas_Ajuste_L");
            entity.Property(e => e.NetoExpL).HasColumnName("Neto_Exp_L");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.PesoBIngenioL).HasColumnName("Peso_B_Ingenio_L");
            entity.Property(e => e.PesoNIngenioL).HasColumnName("Peso_N_Ingenio_L");
            entity.Property(e => e.PolL).HasColumnName("Pol_L");
            entity.Property(e => e.PurezaL).HasColumnName("Pureza_L");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaraExpL).HasColumnName("Tara_Exp_L");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas2RoundVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_2_Round_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgAzucarHaL).HasColumnName("Kg_Azucar_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteHaL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteTonL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgAzucarTonL).HasColumnName("Kg_Azucar_Ton_L");
            entity.Property(e => e.KgMielHaL).HasColumnName("Kg_Miel_Ha_L");
            entity.Property(e => e.KgMielMasAjusteHaL).HasColumnName("Kg_Miel_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgMielMasAjusteTonL).HasColumnName("Kg_Miel_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgMielTonL).HasColumnName("Kg_Miel_Ton_L");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TonDirefenciaL).HasColumnName("Ton_Direfencia_L");
            entity.Property(e => e.TonHaL).HasColumnName("Ton_Ha_L");
            entity.Property(e => e.TonNetoExpL).HasColumnName("Ton_Neto_Exp_L");
            entity.Property(e => e.TonPesoNIngenioL).HasColumnName("Ton_Peso_N_Ingenio_L");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas2Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_2_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaCorta).HasColumnName("Area_Corta");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgAzucarHaL).HasColumnName("Kg_Azucar_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteHaL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteTonL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgAzucarTonL).HasColumnName("Kg_Azucar_Ton_L");
            entity.Property(e => e.KgMielHaL).HasColumnName("Kg_Miel_Ha_L");
            entity.Property(e => e.KgMielMasAjusteHaL).HasColumnName("Kg_Miel_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgMielMasAjusteTonL).HasColumnName("Kg_Miel_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgMielTonL).HasColumnName("Kg_Miel_Ton_L");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TonDirefenciaL).HasColumnName("Ton_Direfencia_L");
            entity.Property(e => e.TonHaL).HasColumnName("Ton_Ha_L");
            entity.Property(e => e.TonNetoExpL).HasColumnName("Ton_Neto_Exp_L");
            entity.Property(e => e.TonPesoNIngenioL).HasColumnName("Ton_Peso_N_Ingenio_L");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesCortaCarretas3Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Corta_Carretas_3_VW", "pd");

            entity.Property(e => e.CortaMecanica).HasColumnName("Corta_Mecanica");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaSiembra).HasColumnName("Distancia_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgAzucarHaL).HasColumnName("Kg_Azucar_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteHaL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgAzucarMasAjusteTonL).HasColumnName("Kg_Azucar_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgAzucarTonL).HasColumnName("Kg_Azucar_Ton_L");
            entity.Property(e => e.KgMielHaL).HasColumnName("Kg_Miel_Ha_L");
            entity.Property(e => e.KgMielMasAjusteHaL).HasColumnName("Kg_Miel_Mas_Ajuste_Ha_L");
            entity.Property(e => e.KgMielMasAjusteTonL).HasColumnName("Kg_Miel_Mas_Ajuste_Ton_L");
            entity.Property(e => e.KgMielTonL).HasColumnName("Kg_Miel_Ton_L");
            entity.Property(e => e.Maquina)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.Safra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TonDirefenciaL).HasColumnName("Ton_Direfencia_L");
            entity.Property(e => e.TonHaL).HasColumnName("Ton_Ha_L");
            entity.Property(e => e.TonNetoExpL).HasColumnName("Ton_Neto_Exp_L");
            entity.Property(e => e.TonPesoNIngenioL).HasColumnName("Ton_Peso_N_Ingenio_L");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesLaborDdtProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Labor_Ddt_Productos_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesPlantaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Planta_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnLotesSocaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Lotes_Soca_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPesoCarretasTb>(entity =>
        {
            entity.HasKey(e => new { e.IdPcarreta, e.NumCorta, e.FechaSiembra, e.NombreLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasLote })
                .HasName("PK1_1")
                .IsClustered(false);

            entity.ToTable("KN_Peso_Carretas_TB", "pd");

            entity.Property(e => e.IdPcarreta)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PCarreta");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AzucarC)
                .HasComputedColumnSql("(([Peso_N_Ingenio]*[Azucar])/(1000))", false)
                .HasColumnName("Azucar_c");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.CastigoC)
                .HasComputedColumnSql("([Peso_B_Ingenio]-[Peso_N_Ingenio])", false)
                .HasColumnName("Castigo_c");
            entity.Property(e => e.DiaDeCorta).HasColumnName("Dia_De_Corta");
            entity.Property(e => e.DiferenciaC)
                .HasComputedColumnSql("([Peso_N_Ingenio]-([Bruto_Exp]-[Tara_Exp]))", false)
                .HasColumnName("Diferencia_c");
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.IdRomanero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Romanero");
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.MielC)
                .HasComputedColumnSql("(([Peso_N_Ingenio]*[Miel])/(1000))", false)
                .HasColumnName("Miel_c");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NetoExp)
                .HasComputedColumnSql("([Bruto_Exp]-[Tara_Exp])", false)
                .HasColumnName("Neto_Exp");
            entity.Property(e => e.NombreChofer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Chofer");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.KnCortaCanaTb).WithMany(p => p.KnPesoCarretasTbs)
                .HasForeignKey(d => new { d.NumCorta, d.FechaSiembra, d.NombreLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefKN_Corta_Cana_TB138");
        });

        modelBuilder.Entity<KnPesoCarretasVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Peso_Carretas_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.BrutoExp).HasColumnName("Bruto_Exp");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeFinca).HasColumnName("FE_Finca");
            entity.Property(e => e.FechaEIngenio).HasColumnName("Fecha_E_Ingenio");
            entity.Property(e => e.FechaSIngenio).HasColumnName("Fecha_S_Ingenio");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.FsFinca).HasColumnName("FS_Finca");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IngenioDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingenio_Descarga");
            entity.Property(e => e.NRomanero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_Romanero");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumBoletaExp).HasColumnName("Num_Boleta_Exp");
            entity.Property(e => e.NumCorta).HasColumnName("Num_Corta");
            entity.Property(e => e.NumRIngenio).HasColumnName("Num_R_Ingenio");
            entity.Property(e => e.PesoBIngenio).HasColumnName("Peso_B_Ingenio");
            entity.Property(e => e.PesoNIngenio).HasColumnName("Peso_N_Ingenio");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TaraExp).HasColumnName("Tara_Exp");
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPlacaChoferTransportistaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_Placa_Chofer_Transportista_VW", "pd");

            entity.Property(e => e.NombreChofer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Chofer");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Trasportista)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoInyeccionProductosTb>(entity =>
        {
            entity.HasKey(e => new { e.IdInyeccion, e.IdRiego, e.IdCabezal, e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK43_1")
                .IsClustered(false);

            entity.ToTable("KN_PO_Inyeccion_Productos_TB", "pd");

            entity.Property(e => e.IdInyeccion)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Inyeccion");
            entity.Property(e => e.IdRiego).HasColumnName("ID_RIEGO");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.SiembraNum)
                .HasDefaultValue(-1)
                .HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");

            entity.HasOne(d => d.RgRiegoTb).WithMany(p => p.KnPoInyeccionProductosTbs)
                .HasForeignKey(d => new { d.IdRiego, d.IdCabezal })
                .HasConstraintName("RefRG_Riego_TB160");

            entity.HasOne(d => d.KnPoPedidoProductosTb).WithMany(p => p.KnPoInyeccionProductosTbs)
                .HasForeignKey(d => new { d.IdPedido, d.IdProducto, d.NumBoleta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefKN_PO_Pedido_Productos_TB162");
        });

        modelBuilder.Entity<KnPoLotesLaborDdtHorasTotalDiasSemanaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labor_Ddt_Horas_Total_DiasSemana_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab)
                .HasMaxLength(30)
                .HasColumnName("Dia_Semana Dom_Sab");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaborDdtHorasTotalVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labor_Ddt_Horas_Total_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaborDdtProductos1Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labor_Ddt_Productos_1_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaborDdtProductos2Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labor_Ddt_Productos_2_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdt1Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_1_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosAux1Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_aux_1_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosAux2Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_aux_2_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosAuxVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_aux_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosHorasCabezalVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_Horas_Cabezal_VW", "pd");

            entity.Property(e => e.Cabezal)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosHorasCabezalVwCruzadoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_Horas_Cabezal_VW_Cruzado_VW", "pd");

            entity.Property(e => e.Cabezal)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_Productos_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<KnPoLotesLaboresDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Lotes_Labores_Ddt_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
        });

        modelBuilder.Entity<KnPoPedidoProductosDepLaborVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_Dep_Labor_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnPoPedidoProductosTb>(entity =>
        {
            entity.HasKey(e => new { e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK43")
                .IsClustered(false);

            entity.ToTable("KN_PO_Pedido_Productos_TB", "pd");

            entity.Property(e => e.IdPedido)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum)
                .HasDefaultValue(-1)
                .HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.KnPoPedidoProductosTbs)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefProductos_TB153");
        });

        modelBuilder.Entity<KnPoPedidoProductosTbAplicacionesAdicionalesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_TB_Aplicaciones_Adicionales_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<KnPoPedidoProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<KnPoPedidoProductosVw1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_VW_1", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CodigoFase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_Fase");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<KnPoPedidoProductosVw2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_VW_2", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CodigoFase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_Fase");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaHoraAprueba).HasColumnName("Fecha_Hora_Aprueba");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<KnPoPedidoProductosVwMaestroErdrequizaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KN_PO_Pedido_Productos_VW_Maestro_ERDRequiza_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KnProductosALaborTb>(entity =>
        {
            entity.HasKey(e => new { e.Departamento, e.Labor, e.AliasLabor, e.Ddt, e.IdProducto })
                .HasName("PK42")
                .IsClustered(false);

            entity.ToTable("KN_Productos_A_Labor_TB", "pd");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.DosisHa)
                .HasDefaultValue(0.0)
                .HasColumnName("Dosis_Ha");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.KnProductosALaborTbs)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("RefProductos_TB149");

            entity.HasOne(d => d.KnDdtLaborTb).WithMany(p => p.KnProductosALaborTbs)
                .HasForeignKey(d => new { d.Departamento, d.Labor, d.AliasLabor, d.Ddt })
                .HasConstraintName("RefKN_Ddt_Labor_TB148");
        });

        modelBuilder.Entity<LaborTDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Labor_T_DDT_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNumero).HasColumnName("Siembra_Numero");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LaborTTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNumero, e.Departamento, e.Labor, e.AliasLabor })
                .HasName("PK3")
                .IsClustered(false);

            entity.ToTable("Labor_T_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNumero).HasColumnName("Siembra_Numero");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("TODO")
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo)
                .HasDefaultValue(true)
                .HasColumnName("Aplicar_A_Todo");

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.LaborTTbs)
                .HasForeignKey(d => d.Departamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefDepartamento_TB73");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.LaborTTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB69");

            entity.HasOne(d => d.LaboresTb).WithMany(p => p.LaborTTbs)
                .HasForeignKey(d => new { d.Labor, d.Departamento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLabores_TB77");
        });

        modelBuilder.Entity<LaborTVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Labor_T_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Encargado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LaboresTb>(entity =>
        {
            entity.HasKey(e => new { e.Labor, e.Departamento })
                .HasName("PK20")
                .IsClustered(false);

            entity.ToTable("Labores_TB", "pd");

            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.LaboresTbs)
                .HasForeignKey(d => d.Departamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefDepartamento_TB33");
        });

        modelBuilder.Entity<LcCtraspSembradorTb>(entity =>
        {
            entity.HasKey(e => new { e.IdSembrador, e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote, e.NumeroCama })
                .HasName("PK7_1")
                .IsClustered(false);

            entity.ToTable("LC_CTrasp_Sembrador_TB", "pd");

            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");

            entity.HasOne(d => d.LcMonitoreoTrasplanteTb).WithMany(p => p.LcCtraspSembradorTbs)
                .HasForeignKey(d => new { d.IdSembrador, d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLC_Monitoreo_Trasplante_TB243");

            entity.HasOne(d => d.CamasLotesPoTb).WithMany(p => p.LcCtraspSembradorTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote, d.NumeroCama })
                .HasConstraintName("RefCamas_Lotes_PO_TB244");
        });

        modelBuilder.Entity<LcCtraspSembradorVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_CTrasp_Sembrador_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcMonitoreoTrasplanteTb>(entity =>
        {
            entity.HasKey(e => new { e.IdSembrador, e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote })
                .HasName("PK32")
                .IsClustered(false);

            entity.ToTable("LC_Monitoreo_Trasplante_TB", "pd");

            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.FallasDeTrasplante).HasColumnName("Fallas_De_Trasplante");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");

            entity.HasOne(d => d.LcSembradorTb).WithMany(p => p.LcMonitoreoTrasplanteTbs)
                .HasForeignKey(d => new { d.IdSembrador, d.Temporada })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLC_Sembrador_TB235");

            entity.HasOne(d => d.LcTrasplanteLoteTb).WithMany(p => p.LcMonitoreoTrasplanteTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .HasConstraintName("RefLC_Trasplante_Lote_TB236");
        });

        modelBuilder.Entity<LcSembradorTb>(entity =>
        {
            entity.HasKey(e => new { e.IdSembrador, e.Temporada })
                .HasName("PK3_2")
                .IsClustered(false);

            entity.ToTable("LC_Sembrador_TB", "pd");

            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteHibridosTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.Tratamiento, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido, e.SiembraNum, e.NombreLote, e.AliasLote })
                .HasName("PK28")
                .IsClustered(false);

            entity.ToTable("LC_Trasplante_Hibridos_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CamaFinal).HasColumnName("Cama_Final");
            entity.Property(e => e.CamaInicial).HasColumnName("Cama_Inicial");

            entity.HasOne(d => d.LcTrasplanteLoteTb).WithMany(p => p.LcTrasplanteHibridosTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .HasConstraintName("RefLC_Trasplante_Lote_TB234");

            entity.HasOne(d => d.HibridosPoTb).WithMany(p => p.LcTrasplanteHibridosTbs)
                .HasForeignKey(d => new { d.Temporada, d.Tratamiento, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefHibridos_PO_TB242");
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorCamasRepetidasVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_Camas_Repetidas_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CamasRepetidas).HasColumnName("Camas_Repetidas");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoFullVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_Lote_Real_Vs_Pagado_Full_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaPagada).HasColumnName("Area_Pagada");
            entity.Property(e => e.AreaSegunLongitudCamas).HasColumnName("Area_Segun_Longitud_Camas");
            entity.Property(e => e.AreaSegunProgOperativo).HasColumnName("Area_Segun_Prog_Operativo");
            entity.Property(e => e.DifAreaLogCamasMPagada).HasColumnName("Dif_Area_Log_Camas_m_Pagada");
            entity.Property(e => e.DifAreaPoMLogCamas).HasColumnName("Dif_Area_PO_m_Log_Camas");
            entity.Property(e => e.DifAreaPoMPagada).HasColumnName("Dif_Area_PO_m_Pagada");
            entity.Property(e => e.DifPagoLogCamasMPagada).HasColumnName("Dif_Pago_Log_Camas_m_Pagada");
            entity.Property(e => e.DifPagoPoMPagada).HasColumnName("Dif_Pago_PO_m_Pagada");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_Lote_Real_Vs_Pagado_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaPagada).HasColumnName("Area_Pagada");
            entity.Property(e => e.AreaSegunProgOperativo).HasColumnName("Area_Segun_Prog_Operativo");
            entity.Property(e => e.DifHa).HasColumnName("Dif_Ha");
            entity.Property(e => e.DifPago).HasColumnName("Dif_Pago");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorRfmSsemanaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_RFM_SSemana_VW", "pd");

            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.InsidenciasDeFallas).HasColumnName("Insidencias_De_Fallas");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.NumeroSembrador).HasColumnName("Numero_Sembrador");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorSfechaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_SFecha_VW", "pd");

            entity.Property(e => e.DineroTotalFecha).HasColumnName("Dinero_Total_Fecha");
            entity.Property(e => e.DineroTotalRealFecha).HasColumnName("Dinero_Total_Real_Fecha");
            entity.Property(e => e.FallasTotalFecha).HasColumnName("Fallas_Total_Fecha");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.MetrosTotalFecha).HasColumnName("Metros_Total_Fecha");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorSloteVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_SLote_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.DineroTotalLote).HasColumnName("Dinero_Total_Lote");
            entity.Property(e => e.DineroTotalRealLote).HasColumnName("Dinero_Total_Real_Lote");
            entity.Property(e => e.FallasTotalLote).HasColumnName("Fallas_Total_Lote");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.MetrosTotalLote).HasColumnName("Metros_Total_Lote");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorSsemanaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_SSemana_VW", "pd");

            entity.Property(e => e.DineroTotalLoteSemana).HasColumnName("Dinero_Total_Lote_Semana");
            entity.Property(e => e.DineroTotalRealLoteSemana).HasColumnName("Dinero_Total_Real_Lote_Semana");
            entity.Property(e => e.FallasTotalLoteSemana).HasColumnName("Fallas_Total_Lote_Semana");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.MetrosTotalLoteSemana).HasColumnName("Metros_Total_Lote_Semana");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.NumeroSembrador).HasColumnName("Numero_Sembrador");
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoCtraspSembradorVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_CTrasp_Sembrador_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.FallasDeTrasplante).HasColumnName("Fallas_De_Trasplante");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.NumeroCama).HasColumnName("Numero_Cama");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteMonitoreoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LC_Trasplante_Lote_Monitoreo_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.FallasDeTrasplante).HasColumnName("Fallas_De_Trasplante");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.IdSembrador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Sembrador");
            entity.Property(e => e.MetrosXFallas).HasColumnName("Metros_X_Fallas");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreSembrador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sembrador");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMetro).HasColumnName("Precio_Metro");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LcTrasplanteLoteTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote })
                .HasName("PK6_1")
                .IsClustered(false);

            entity.ToTable("LC_Trasplante_Lote_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.LotesPoTb).WithOne(p => p.LcTrasplanteLoteTb)
                .HasForeignKey<LcTrasplanteLoteTb>(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .HasConstraintName("RefLotes_PO_TB246");
        });

        modelBuilder.Entity<LcVvTrasplanteSalidaViveroTb>(entity =>
        {
            entity.HasKey(e => new { e.DiaSiembra, e.Cultivo, e.Variedad, e.Hibrido, e.TemporadaD, e.SiembraNumD, e.NombreLoteD, e.AliasLoteD, e.FechaHoraSvv, e.TemporadaR, e.SiembraNumR, e.NombreLoteR, e.AliasLoteR, e.LoteSemilla })
                .HasName("PK31_1")
                .IsClustered(false);

            entity.ToTable("LC_VV_Trasplante_Salida_Vivero_TB", "pd");

            entity.Property(e => e.DiaSiembra).HasColumnName("Dia_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TemporadaD)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_D");
            entity.Property(e => e.SiembraNumD).HasColumnName("Siembra_Num_D");
            entity.Property(e => e.NombreLoteD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote_D");
            entity.Property(e => e.AliasLoteD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote_D");
            entity.Property(e => e.FechaHoraSvv).HasColumnName("Fecha_Hora_SVV");
            entity.Property(e => e.TemporadaR)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_R");
            entity.Property(e => e.SiembraNumR).HasColumnName("Siembra_Num_R");
            entity.Property(e => e.NombreLoteR)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote_R");
            entity.Property(e => e.AliasLoteR)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote_R");
            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.NumBandejasTLc).HasColumnName("Num_Bandejas_T_LC");

            entity.HasOne(d => d.LcTrasplanteLoteTb).WithMany(p => p.LcVvTrasplanteSalidaViveroTbs)
                .HasForeignKey(d => new { d.TemporadaR, d.SiembraNumR, d.NombreLoteR, d.AliasLoteR })
                .HasConstraintName("RefLC_Trasplante_Lote_TB240");

            entity.HasOne(d => d.VvSalidaViveroTb).WithMany(p => p.LcVvTrasplanteSalidaViveroTbs)
                .HasForeignKey(d => new { d.DiaSiembra, d.TemporadaD, d.Cultivo, d.Variedad, d.SiembraNumD, d.NombreLoteD, d.Hibrido, d.AliasLoteD, d.FechaHoraSvv, d.LoteSemilla })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefVV_Salida_Vivero_TB237");
        });

        modelBuilder.Entity<LotesFisicosTb>(entity =>
        {
            entity.HasKey(e => e.NombreLote)
                .HasName("PK22")
                .IsClustered(false);

            entity.ToTable("Lotes_Fisicos_TB", "pd");

            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LotesPoTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNum, e.NombreLote, e.AliasLote })
                .HasName("PK4")
                .IsClustered(false);

            entity.ToTable("Lotes_PO_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.ColmenasPorHa).HasColumnName("Colmenas_Por_Ha");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Fumig)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Norte-Sur");
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.TipoPlastico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Plastico");

            entity.HasOne(d => d.NombreLoteNavigation).WithMany(p => p.LotesPoTbs)
                .HasForeignKey(d => d.NombreLote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLotes_Fisicos_TB14");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.LotesPoTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB25");
        });

        modelBuilder.Entity<LotesPoTrazabilidadFechaCosechaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Lotes_PO_Trazabilidad_Fecha_Cosecha_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.CodigosTrazabilidad)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Codigos_Trazabilidad");
            entity.Property(e => e.ColmenasPorHa).HasColumnName("Colmenas_Por_Ha");
            entity.Property(e => e.FechaCosecha).HasColumnName("Fecha_Cosecha");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Fumig)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.Orientacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoPlastico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Plastico");
        });

        modelBuilder.Entity<LotesVariedadAreaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Lotes_Variedad_Area_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LvScizerMasRangosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LV_SCizer_Mas_Rangos_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FechaHoraFin).HasColumnName("Fecha_Hora_Fin");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.FrutosRango).HasColumnName("Frutos_Rango");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KilosRango).HasColumnName("Kilos_Rango");
            entity.Property(e => e.MayorIgualQue).HasColumnName("Mayor_Igual_Que");
            entity.Property(e => e.MenorQue).HasColumnName("Menor_Que");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreRango)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Rango");
            entity.Property(e => e.NombreScizer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_SCizer");
            entity.Property(e => e.PesoFrutoRango).HasColumnName("Peso_Fruto_Rango");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LvTermporadaTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK12")
                .IsClustered(false);

            entity.ToTable("LV_Termporada_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.LvTermporadaTbs)
                .HasForeignKey(d => d.Temporada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefTemporada_TB62");

            entity.HasOne(d => d.LotesPoTb).WithMany(p => p.LvTermporadaTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.NombreLote, d.AliasLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLotes_PO_TB93");

            entity.HasOne(d => d.HibridosPoTb).WithMany(p => p.LvTermporadaTbs)
                .HasForeignKey(d => new { d.Temporada, d.Tratamiento, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefHibridos_PO_TB97");
        });

        modelBuilder.Entity<LvTermporadaVersionPoTb>(entity =>
        {
            entity.HasKey(e => new { e.Version, e.Temporada, e.Fecha, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK12_1")
                .IsClustered(false);

            entity.ToTable("LV_Termporada_Version_PO_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");

            entity.HasOne(d => d.VersionPoTb).WithMany(p => p.LvTermporadaVersionPoTbs)
                .HasForeignKey(d => new { d.Version, d.Temporada, d.Fecha })
                .HasConstraintName("RefVersion_PO_TB210");
        });

        modelBuilder.Entity<LvaLaborTDdt1Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LVA_Labor_T_DDT_1_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LvaLaborTDdt2Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LVA_Labor_T_DDT_2_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LvaLaborTDdt3SumAreaLaborVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LVA_Labor_T_DDT_3_Sum_Area_Labor_VW", "pd");

            entity.Property(e => e.AreaLabor).HasColumnName("Area_Labor");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Labor)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LvaLaborTDdtVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LVA_Labor_T_DDT_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtMetereologiaTb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MT_Metereologia_TB", "pd");

            entity.Property(e => e.DireccionViento).HasColumnName("Direccion_Viento");
            entity.Property(e => e.HumedadRelativa).HasColumnName("Humedad_Relativa");
            entity.Property(e => e.VelocidadViento).HasColumnName("Velocidad_Viento");
        });

        modelBuilder.Entity<MtPlubiometroTb>(entity =>
        {
            entity.HasKey(e => e.IdPlubiometro)
                .HasName("PK82")
                .IsClustered(false);

            entity.ToTable("MT_Plubiometro_TB", "pd");

            entity.Property(e => e.IdPlubiometro)
                .ValueGeneratedNever()
                .HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtPlubiometrosMasFechasVwd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Plubiometros_Mas_Fechas_VWd", "pd");

            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtRegistroLluviasTb>(entity =>
        {
            entity.HasKey(e => new { e.IdRlluvia, e.IdPlubiometro, e.FechaHoraLectura });

            entity.ToTable("MT_Registro_Lluvias_TB", "pd");

            entity.Property(e => e.IdRlluvia)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_RLluvia");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.FechaHoraLectura).HasColumnName("Fecha_Hora_Lectura");
            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");

            entity.HasOne(d => d.IdPlubiometroNavigation).WithMany(p => p.MtRegistroLluviasTbs)
                .HasForeignKey(d => d.IdPlubiometro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefMT_Plubiometro_TB202");
        });

        modelBuilder.Entity<MtRegistrosLluviasVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Registros_Lluvias_VW", "pd");

            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");
            entity.Property(e => e.FechaHora).HasColumnName("Fecha_Hora");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumasTotalesAfechaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Sumas_Totales_AFecha_VW", "pd");

            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");
            entity.Property(e => e.FechaHora).HasColumnName("Fecha_Hora");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaAnioAfecha).HasColumnName("Suma_Anio_AFecha");
            entity.Property(e => e.SumaMesAfecha).HasColumnName("Suma_Mes_AFecha");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumasTotalesAfechaVw1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Sumas_Totales_AFecha_VW_1", "pd");

            entity.Property(e => e.CantidadMm0).HasColumnName("Cantidad_mm0");
            entity.Property(e => e.CantidadMm1).HasColumnName("Cantidad_mm1");
            entity.Property(e => e.FechaHora0).HasColumnName("Fecha_Hora0");
            entity.Property(e => e.FechaHora1).HasColumnName("Fecha_Hora1");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaAnioAfecha0).HasColumnName("Suma_Anio_AFecha0");
            entity.Property(e => e.SumaAnioAfecha1).HasColumnName("Suma_Anio_AFecha1");
            entity.Property(e => e.SumaMesAfecha0).HasColumnName("Suma_Mes_AFecha0");
            entity.Property(e => e.SumaMesAfecha1).HasColumnName("Suma_Mes_AFecha1");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumasTotalesAfechaVw2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Sumas_Totales_AFecha_VW_2", "pd");

            entity.Property(e => e.FechaHora0).HasColumnName("Fecha_Hora0");
            entity.Property(e => e.FechaHora1).HasColumnName("Fecha_Hora1");
            entity.Property(e => e.FechaHora2).HasColumnName("Fecha_Hora2");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaAñoAfecha0).HasColumnName("Suma_Año_AFecha0");
            entity.Property(e => e.SumaAñoAfecha1).HasColumnName("Suma_Año_AFecha1");
            entity.Property(e => e.SumaAñoAfecha2).HasColumnName("Suma_Año_AFecha2");
            entity.Property(e => e.SumaMesAfecha0).HasColumnName("Suma_Mes_AFecha0");
            entity.Property(e => e.SumaMesAfecha1).HasColumnName("Suma_Mes_AFecha1");
            entity.Property(e => e.SumaMesAfecha2).HasColumnName("Suma_Mes_AFecha2");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumasTotalesAfechaVw3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Sumas_Totales_AFecha_VW_3", "pd");

            entity.Property(e => e.FechaHora0).HasColumnName("Fecha_Hora0");
            entity.Property(e => e.FechaHora1).HasColumnName("Fecha_Hora1");
            entity.Property(e => e.FechaHora2).HasColumnName("Fecha_Hora2");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaAñoAfecha0).HasColumnName("Suma_Año_AFecha0");
            entity.Property(e => e.SumaAñoAfecha1).HasColumnName("Suma_Año_AFecha1");
            entity.Property(e => e.SumaAñoAfecha2).HasColumnName("Suma_Año_AFecha2");
            entity.Property(e => e.SumaMesAfecha0).HasColumnName("Suma_Mes_AFecha0");
            entity.Property(e => e.SumaMesAfecha1).HasColumnName("Suma_Mes_AFecha1");
            entity.Property(e => e.SumaMesAfecha2).HasColumnName("Suma_Mes_AFecha2");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumasTotalesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_Sumas_Totales_VW", "pd");

            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");
            entity.Property(e => e.FechaHora).HasColumnName("Fecha_Hora");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumaxAñoAfechaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxAño_AFecha_VW", "pd");

            entity.Property(e => e.FechaHoraLectura).HasColumnName("Fecha_Hora_Lectura");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaAnioAfecha).HasColumnName("Suma_Anio_AFecha");
        });

        modelBuilder.Entity<MtSumaxAñoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxAño_VW", "pd");

            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
        });

        modelBuilder.Entity<MtSumaxDiaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxDia_VW", "pd");

            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");
            entity.Property(e => e.FechaHora).HasColumnName("Fecha_Hora");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumaxDiaVw0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxDia_VW_0", "pd");

            entity.Property(e => e.CantidadMm).HasColumnName("Cantidad_mm");
            entity.Property(e => e.FechaHora).HasColumnName("Fecha_Hora");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MtSumaxMesAfechaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxMes_AFecha_VW", "pd");

            entity.Property(e => e.FechaHoraLectura).HasColumnName("Fecha_Hora_Lectura");
            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
            entity.Property(e => e.SumaMesAfecha).HasColumnName("Suma_Mes_AFecha");
        });

        modelBuilder.Entity<MtSumaxMesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MT_SumaxMes_VW", "pd");

            entity.Property(e => e.IdPlubiometro).HasColumnName("ID_Plubiometro");
        });

        modelBuilder.Entity<NavegadorTb>(entity =>
        {
            entity.HasKey(e => new { e.Labor, e.Departamento, e.Fecha, e.Personas, e.Descripcion })
                .HasName("PK56")
                .IsClustered(false);

            entity.ToTable("Navegador_TB", "pd");

            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.LaboresTb).WithMany(p => p.NavegadorTbs)
                .HasForeignKey(d => new { d.Labor, d.Departamento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLabores_TB164");
        });

        modelBuilder.Entity<NavegadorVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Navegador_VW", "pd");

            entity.Property(e => e.AreaFisica).HasColumnName("Area_Fisica");
            entity.Property(e => e.AreaTotal).HasColumnName("Area_Total");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PilaTb>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.Temporada, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido })
                .HasName("PK97")
                .IsClustered(false);

            entity.ToTable("Pila_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.KilosBrutoPila).HasColumnName("Kilos_Bruto_Pila");

            entity.HasOne(d => d.LvTermporadaTb).WithMany(p => p.PilaTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.Tratamiento, d.NombreLote, d.AliasLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .HasConstraintName("RefLV_Termporada_TB218");
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.ProgFertilizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_Fertilizacion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_1", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_1_1", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt11Din>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_1_1_DIN", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt1Din>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_1_DIN", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_2", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt2DinVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_2_DIN_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt2EstVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_2_EST_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AplicarA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aplicar_A");
            entity.Property(e => e.AplicarATodo).HasColumnName("Aplicar_A_Todo");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_Total");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ProgFitoProteccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prog_FitoProteccion");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.Variedad)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoLotesLaborDdtProductosVwFt2Master>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PO_Lotes_Labor_Ddt_Productos_VW_FT_2_Master", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoProductosALaborTb>(entity =>
        {
            entity.HasKey(e => new { e.Temporada, e.SiembraNumero, e.Departamento, e.Labor, e.AliasLabor, e.Ddt, e.IdProducto })
                .HasName("PK9")
                .IsClustered(false);

            entity.ToTable("PO_Productos_A_Labor_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNumero).HasColumnName("Siembra_Numero");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.HorasAgua).HasColumnName("Horas_Agua");
            entity.Property(e => e.HorasInyeccion).HasColumnName("Horas_Inyeccion");
            entity.Property(e => e.HorasLavado).HasColumnName("Horas_Lavado");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.PoProductosALaborTbs)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("RefProductos_TB116");

            entity.HasOne(d => d.DdtLaborTb).WithMany(p => p.PoProductosALaborTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNumero, d.Departamento, d.Labor, d.AliasLabor, d.Ddt })
                .HasConstraintName("RefDDT_Labor_TB117");
        });

        modelBuilder.Entity<ProductosCertificacionesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Productos_Certificaciones_VW", "pd");

            entity.Property(e => e.Comentarios)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ConcentracionIactivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concentracion_IActivo");
            entity.Property(e => e.DdtPrecosecha).HasColumnName("Ddt_Precosecha");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.IngredienteActivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingrediente_Activo");
            entity.Property(e => e.NombreCertificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Certificacion");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.RestriccionIngreso).HasColumnName("Restriccion_Ingreso");
            entity.Property(e => e.TipoUso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Uso");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<ProductosTb>(entity =>
        {
            entity.HasKey(e => e.IdProducto)
                .HasName("PK24")
                .IsClustered(false);

            entity.ToTable("Productos_TB", "pd");

            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.ConcentracionIactivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concentracion_IActivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IngredienteActivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingrediente_Activo");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.RestriccionIngreso)
                .HasDefaultValue(0.0)
                .HasColumnName("Restriccion_Ingreso");
            entity.Property(e => e.TipoUso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Uso");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<ProductosTbFaseVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Productos_TB_Fase_VW", "pd");

            entity.Property(e => e.CodigoFase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_Fase");
            entity.Property(e => e.ConcentracionIactivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concentracion_IActivo");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.IngredienteActivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ingrediente_Activo");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.ProductoTipoUso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Producto_Tipo_Uso");
            entity.Property(e => e.RestriccionIngreso).HasColumnName("Restriccion_Ingreso");
            entity.Property(e => e.TipoUso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Uso");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<RangosScizerTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreRango, e.Temporada, e.NombreScizer, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido, e.FechaHoraInicio })
                .HasName("PK12_2")
                .IsClustered(false);

            entity.ToTable("Rangos_SCizer_TB", "pd");

            entity.Property(e => e.NombreRango)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Rango");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreScizer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_SCizer");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.FrutosRango).HasColumnName("Frutos_Rango");
            entity.Property(e => e.KilosRango).HasColumnName("Kilos_Rango");
            entity.Property(e => e.MayorIgualQue).HasColumnName("Mayor_Igual_Que");
            entity.Property(e => e.MenorQue).HasColumnName("Menor_Que");
            entity.Property(e => e.PesoFrutoRango)
                .HasComputedColumnSql("([Kilos_Rango]/[Frutos_Rango])", false)
                .HasColumnName("Peso_Fruto_Rango");

            entity.HasOne(d => d.ScizerTb).WithMany(p => p.RangosScizerTbs)
                .HasForeignKey(d => new { d.NombreScizer, d.Temporada, d.SiembraNum, d.Tratamiento, d.NombreLote, d.AliasLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido, d.FechaHoraInicio })
                .HasConstraintName("RefSCizer_TB216");
        });

        modelBuilder.Entity<RcabezaleroProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdRcabezalero, e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK62")
                .IsClustered(false);

            entity.ToTable("RCabezalero_Producto_TB", "pd");

            entity.Property(e => e.IdRcabezalero)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_RCabezalero");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraRcabezalero).HasColumnName("Fecha_Hora_RCabezalero");
            entity.Property(e => e.IdEmpleadoRcabezalero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_RCabezalero");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.KnPoPedidoProductosTb).WithMany(p => p.RcabezaleroProductoTbs)
                .HasForeignKey(d => new { d.IdPedido, d.IdProducto, d.NumBoleta })
                .HasConstraintName("RefKN_PO_Pedido_Productos_TB174");
        });

        modelBuilder.Entity<RdistribuidorProductoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdRdistribuidos, e.IdPedido, e.IdProducto, e.NumBoleta })
                .HasName("PK61")
                .IsClustered(false);

            entity.ToTable("RDistribuidor_Producto_TB", "pd");

            entity.Property(e => e.IdRdistribuidos)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_RDistribuidos");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.FechaHoraRdistribuidor).HasColumnName("Fecha_Hora_RDistribuidor");
            entity.Property(e => e.IdEmpleadoRdistribuidor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_RDistribuidor");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");

            entity.HasOne(d => d.KnPoPedidoProductosTb).WithMany(p => p.RdistribuidorProductoTbs)
                .HasForeignKey(d => new { d.IdPedido, d.IdProducto, d.NumBoleta })
                .HasConstraintName("RefKN_PO_Pedido_Productos_TB172");
        });

        modelBuilder.Entity<ReporteConsultaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Reporte_Consulta_VW", "pd");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemana).HasColumnName("Dia_Semana");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.FechaTrasplante).HasColumnName("Fecha_Trasplante");
        });

        modelBuilder.Entity<RgCabezalTb>(entity =>
        {
            entity.HasKey(e => e.IdCabezal)
                .HasName("PK3_1")
                .IsClustered(false);

            entity.ToTable("RG_Cabezal_TB", "pd");

            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.ConstanteCaudal).HasColumnName("Constante_Caudal");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoCaudalimetro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Caudalimetro");
        });

        modelBuilder.Entity<RgEncargadoRinyeccionTb>(entity =>
        {
            entity.HasKey(e => new { e.IdEncargado, e.IdRiego, e.IdCabezal })
                .HasName("PK49")
                .IsClustered(false);

            entity.ToTable("RG_Encargado_RInyeccion_TB", "pd");

            entity.Property(e => e.IdEncargado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Encargado");
            entity.Property(e => e.IdRiego).HasColumnName("ID_RIEGO");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.FugueroCabezalero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("CABEZALERO")
                .HasColumnName("Fuguero_Cabezalero");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RgRiegoTb).WithMany(p => p.RgEncargadoRinyeccionTbs)
                .HasForeignKey(d => new { d.IdRiego, d.IdCabezal })
                .HasConstraintName("RefRG_Riego_TB155");
        });

        modelBuilder.Entity<RgMotor>(entity =>
        {
            entity.HasKey(e => new { e.IdMotor, e.IdCabezal })
                .HasName("PK4_1")
                .IsClustered(false);

            entity.ToTable("RG_Motor", "pd");

            entity.Property(e => e.IdMotor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Motor");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NombreMotor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Motor");

            entity.HasOne(d => d.IdCabezalNavigation).WithMany(p => p.RgMotors)
                .HasForeignKey(d => d.IdCabezal)
                .HasConstraintName("RefRG_Cabezal_TB154");
        });

        modelBuilder.Entity<RgRiegoLotesAreaRiegoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RG_Riego_Lotes_AreaRiego_VW", "pd");

            entity.Property(e => e.AreaRiego).HasColumnName("Area_Riego");
            entity.Property(e => e.CaudalimetroFinal).HasColumnName("Caudalimetro_Final");
            entity.Property(e => e.CaudalimetroInicial).HasColumnName("Caudalimetro_Inicial");
            entity.Property(e => e.ConstanteCaudal).HasColumnName("Constante_Caudal");
            entity.Property(e => e.FechaRinyeccion).HasColumnName("Fecha_RInyeccion");
            entity.Property(e => e.HorasRiego).HasColumnName("Horas_Riego");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.IdRiego).HasColumnName("ID_RIEGO");
            entity.Property(e => e.NumBoleta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Num_Boleta");
            entity.Property(e => e.PsiEntrada).HasColumnName("PSI_Entrada");
            entity.Property(e => e.PsiSalida).HasColumnName("PSI_Salida");
            entity.Property(e => e.TemporadaSafra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_Safra");
            entity.Property(e => e.VolumenM3HoraHa).HasColumnName("Volumen_M3_Hora_Ha");
            entity.Property(e => e.VolumenRiegoM3).HasColumnName("Volumen_Riego_M3");
        });

        modelBuilder.Entity<RgRiegoLotesM3HoraHaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RG_Riego_Lotes_M3_Hora_Ha_VW", "pd");

            entity.Property(e => e.AreaRiego).HasColumnName("Area_Riego");
            entity.Property(e => e.CaudalimetroFinal).HasColumnName("Caudalimetro_Final");
            entity.Property(e => e.CaudalimetroInicial).HasColumnName("Caudalimetro_Inicial");
            entity.Property(e => e.ConstanteCaudal).HasColumnName("Constante_Caudal");
            entity.Property(e => e.FechaRinyeccion).HasColumnName("Fecha_RInyeccion");
            entity.Property(e => e.HorasRiego).HasColumnName("Horas_Riego");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.IdRiego).HasColumnName("ID_RIEGO");
            entity.Property(e => e.NumBoleta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Num_Boleta");
            entity.Property(e => e.PsiEntrada).HasColumnName("PSI_Entrada");
            entity.Property(e => e.PsiSalida).HasColumnName("PSI_Salida");
            entity.Property(e => e.TemporadaSafra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_Safra");
            entity.Property(e => e.VolumenM3HoraHa).HasColumnName("Volumen_M3_Hora_Ha");
            entity.Property(e => e.VolumenRiegoM3).HasColumnName("Volumen_Riego_M3");
        });

        modelBuilder.Entity<RgRiegoLotesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RG_Riego_Lotes_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.CaudalimetroFinal).HasColumnName("Caudalimetro_Final");
            entity.Property(e => e.CaudalimetroInicial).HasColumnName("Caudalimetro_Inicial");
            entity.Property(e => e.ConstanteCaudal).HasColumnName("Constante_Caudal");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRinyeccion).HasColumnName("Fecha_RInyeccion");
            entity.Property(e => e.HorasRiego).HasColumnName("Horas_Riego");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.IdRiego).HasColumnName("ID_RIEGO");
            entity.Property(e => e.NumBoleta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Num_Boleta");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PsiEntrada).HasColumnName("PSI_Entrada");
            entity.Property(e => e.PsiSalida).HasColumnName("PSI_Salida");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.TemporadaSafra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_Safra");
        });

        modelBuilder.Entity<RgRiegoTb>(entity =>
        {
            entity.HasKey(e => new { e.IdRiego, e.IdCabezal })
                .HasName("PK2_2")
                .IsClustered(false);

            entity.ToTable("RG_Riego_TB", "pd");

            entity.Property(e => e.IdRiego)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_RIEGO");
            entity.Property(e => e.IdCabezal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CABEZAL");
            entity.Property(e => e.CaudalimetroFinal)
                .HasDefaultValue(-1.0)
                .HasColumnName("Caudalimetro_Final");
            entity.Property(e => e.CaudalimetroInicial)
                .HasDefaultValue(-1.0)
                .HasColumnName("Caudalimetro_Inicial");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRinyeccion).HasColumnName("Fecha_RInyeccion");
            entity.Property(e => e.HorasRiego).HasColumnName("Horas_Riego");
            entity.Property(e => e.NumBoleta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Num_Boleta");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PsiEntrada)
                .HasDefaultValue(-1.0)
                .HasColumnName("PSI_Entrada");
            entity.Property(e => e.PsiSalida)
                .HasDefaultValue(-1.0)
                .HasColumnName("PSI_Salida");
            entity.Property(e => e.TemporadaSafra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_Safra");

            entity.HasOne(d => d.IdCabezalNavigation).WithMany(p => p.RgRiegoTbs)
                .HasForeignKey(d => d.IdCabezal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefRG_Cabezal_TB156");
        });

        modelBuilder.Entity<ScizerDatosCosechaTemporadaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Datos_Cosecha_Temporada_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.FrutosScizersAliasHibrido).HasColumnName("Frutos_Scizers_Alias_Hibrido");
            entity.Property(e => e.FrutosScizersAliasHibridoLote).HasColumnName("Frutos_Scizers_Alias_Hibrido_Lote");
            entity.Property(e => e.FrutosTemporada).HasColumnName("Frutos_Temporada");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgExportableScizerAhibridoLote).HasColumnName("Kg_Exportable_Scizer_AHibrido_Lote");
            entity.Property(e => e.KgHaPila).HasColumnName("Kg_Ha_Pila");
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KgHaScizersAliasHibrido).HasColumnName("Kg_Ha_Scizers_Alias_Hibrido");
            entity.Property(e => e.KgHaScizersAliasHibridoLote).HasColumnName("Kg_Ha_Scizers_Alias_Hibrido_Lote");
            entity.Property(e => e.KgHaTemporada).HasColumnName("Kg_Ha_Temporada");
            entity.Property(e => e.KilosBrutoPila).HasColumnName("Kilos_Bruto_Pila");
            entity.Property(e => e.KilosScizerAhibridoLote).HasColumnName("%_Kilos_Scizer_AHibrido_Lote");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.KilosScizersAliasHibrido).HasColumnName("Kilos_Scizers_Alias_Hibrido");
            entity.Property(e => e.KilosScizersAliasHibridoLote).HasColumnName("Kilos_Scizers_Alias_Hibrido_Lote");
            entity.Property(e => e.KilosTemporada).HasColumnName("Kilos_Temporada");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.PesoFrutoScizersAliasHibrido).HasColumnName("Peso_Fruto_Scizers_Alias_Hibrido");
            entity.Property(e => e.PesoFrutoTemporada).HasColumnName("Peso_Fruto_Temporada");
            entity.Property(e => e.RechazoScizerAhibridoLote).HasColumnName("%_Rechazo_Scizer_AHibrido_Lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvDiaMasPilaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Dia_Mas_Pila_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgHaPila).HasColumnName("Kg_Ha_Pila");
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KilosBrutoPila).HasColumnName("Kilos_Bruto_Pila");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvDiaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Dia_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvSumasDiaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Sumas(Dia)_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvTemporadaSnumTratVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Temporada_SNum_Trat_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvTemporadaTotalVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Temporada_Total_VW", "pd");

            entity.Property(e => e.AreaTemporada).HasColumnName("Area_Temporada");
            entity.Property(e => e.DestandarTemporada).HasColumnName("DEstandar_Temporada");
            entity.Property(e => e.FrutosTemporada).HasColumnName("Frutos_Temporada");
            entity.Property(e => e.KgHaTemporada).HasColumnName("Kg_Ha_Temporada");
            entity.Property(e => e.KilosTemporada).HasColumnName("Kilos_Temporada");
            entity.Property(e => e.PesoFrutoTemporada).HasColumnName("Peso_Fruto_Temporada");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerMasRangosLvTemporadaVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCizer_Mas_Rangos_LV_Temporada_VW", "pd");

            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.AreaVariedad).HasColumnName("Area_Variedad");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FrutosScizers).HasColumnName("Frutos_Scizers");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KgHaScizers).HasColumnName("Kg_Ha_Scizers");
            entity.Property(e => e.KilosScizers).HasColumnName("Kilos_Scizers");
            entity.Property(e => e.PesoFrutoScizers).HasColumnName("Peso_Fruto_Scizers");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScizerTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreScizer, e.Temporada, e.SiembraNum, e.Tratamiento, e.NombreLote, e.AliasLote, e.Cultivo, e.Variedad, e.Hibrido, e.AliasHibrido, e.FechaHoraInicio })
                .HasName("PK11")
                .IsClustered(false);

            entity.ToTable("SCizer_TB", "pd");

            entity.Property(e => e.NombreScizer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_SCizer");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasHibrido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Hibrido");
            entity.Property(e => e.FechaHoraInicio).HasColumnName("Fecha_Hora_Inicio");
            entity.Property(e => e.Destandar).HasColumnName("DEstandar");
            entity.Property(e => e.FechaHoraFin).HasColumnName("Fecha_Hora_Fin");

            entity.HasOne(d => d.LvTermporadaTb).WithMany(p => p.ScizerTbs)
                .HasForeignKey(d => new { d.Temporada, d.SiembraNum, d.Tratamiento, d.NombreLote, d.AliasLote, d.Cultivo, d.Variedad, d.Hibrido, d.AliasHibrido })
                .HasConstraintName("RefLV_Termporada_TB212");
        });

        modelBuilder.Entity<TemporadaTb>(entity =>
        {
            entity.HasKey(e => e.Temporada)
                .HasName("PK1")
                .IsClustered(false);

            entity.ToTable("Temporada_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
        });

        modelBuilder.Entity<UnionLaboresDdtProductosKnPoDepSumDosisLotesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_Ddt_Productos_KN_PO_Dep_Sum_Dosis_Lotes_VW", "pd");

            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.SumasDosis).HasColumnName("Sumas_Dosis");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<UnionLaboresDdtProductosKnPoDepVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_Ddt_Productos_KN_PO_Dep_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.DosisHa).HasColumnName("Dosis_Ha");
            entity.Property(e => e.DosisLote).HasColumnName("Dosis_Lote");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.Labor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
        });

        modelBuilder.Entity<UnionLaboresKnPoDepRealVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_KN_PO_Dep_Real_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaHoraAprueba).HasColumnName("Fecha_Hora_Aprueba");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_lote");
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<UnionLaboresKnPoDepSumProductosRealVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_KN_PO_Dep_Sum_Productos_Real_VW", "pd");

            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Unidad_Medida");
            entity.Property(e => e.UnidadesTotales).HasColumnName("Unidades_Totales");
        });

        modelBuilder.Entity<UnionLaboresKnPoDepTeoricoMrealVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_KN_PO_Dep_Teorico_MReal_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
        });

        modelBuilder.Entity<UnionLaboresKnPoDepVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_KN_PO_Dep_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemanaDomSab).HasColumnName("Dia_Semana_Dom_Sab");
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaLabor).HasColumnName("Fecha_Labor");
        });

        modelBuilder.Entity<UnionLaboresKnPoDepVwCruzadoVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Union_Labores_KN_PO_Dep_VW_Cruzado_VW", "pd");

            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsuarioDepVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Usuario_Dep_VW", "pd");

            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnName("Fecha_Creacion");
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado");
            entity.Property(e => e.RolDeUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Rol_De_Usuario");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsuarioTb>(entity =>
        {
            entity.HasKey(e => e.Usuario)
                .HasName("PK2")
                .IsClustered(false);

            entity.ToTable("Usuario_TB", "pd");

            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnName("Fecha_Creacion");
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado");
            entity.Property(e => e.RolDeUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("GENERAL")
                .HasColumnName("Rol_De_Usuario");

            entity.HasMany(d => d.Departamentos).WithMany(p => p.Usuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "DepUsuarioTb",
                    r => r.HasOne<DepartamentoTb>().WithMany()
                        .HasForeignKey("Departamento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("RefDepartamento_TB105"),
                    l => l.HasOne<UsuarioTb>().WithMany()
                        .HasForeignKey("Usuario")
                        .HasConstraintName("RefUsuario_TB104"),
                    j =>
                    {
                        j.HasKey("Usuario", "Departamento")
                            .HasName("PK23")
                            .IsClustered(false);
                        j.ToTable("Dep_Usuario_TB", "pd");
                        j.IndexerProperty<string>("Usuario")
                            .HasMaxLength(20)
                            .IsUnicode(false);
                        j.IndexerProperty<string>("Departamento")
                            .HasMaxLength(50)
                            .IsUnicode(false);
                    });
        });

        modelBuilder.Entity<ValvulasTb>(entity =>
        {
            entity.HasKey(e => new { e.NombreLote, e.NombreValvula })
                .HasName("PK7")
                .IsClustered(false);

            entity.ToTable("Valvulas_TB", "pd");

            entity.Property(e => e.NombreLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote");
            entity.Property(e => e.NombreValvula)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Nombre_Valvula");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.NombreLoteNavigation).WithMany(p => p.ValvulasTbs)
                .HasForeignKey(d => d.NombreLote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefLotes_Fisicos_TB12");
        });

        modelBuilder.Entity<VariedadTb>(entity =>
        {
            entity.HasKey(e => new { e.Cultivo, e.Variedad })
                .HasName("PK14")
                .IsClustered(false);

            entity.ToTable("Variedad_TB", "pd");

            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NombreAbreviatura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Nombre_Abreviatura");
        });

        modelBuilder.Entity<VersionPoTb>(entity =>
        {
            entity.HasKey(e => new { e.Version, e.Temporada, e.Fecha })
                .HasName("PK57_1")
                .IsClustered(false);

            entity.ToTable("Version_PO_TB", "pd");

            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.TemporadaNavigation).WithMany(p => p.VersionPoTbs)
                .HasForeignKey(d => d.Temporada)
                .HasConstraintName("RefTemporada_TB165");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.AliasLabor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alias_Labor");
            entity.Property(e => e.AliasLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote");
            entity.Property(e => e.Aprueba)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AreaSiembra).HasColumnName("Area_Siembra");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBase).HasColumnName("Fecha_Base");
            entity.Property(e => e.FechaPedido).HasColumnName("Fecha_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.Rcabezalero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RCabezalero");
            entity.Property(e => e.Rdistribuye)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RDistribuye");
            entity.Property(e => e.Recive)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNum).HasColumnName("Siembra_Num");
            entity.Property(e => e.Temporada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesPorLote).HasColumnName("Unidades_Por_Lote");
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.FechaHoraAprueba).HasColumnName("Fecha_Hora_Aprueba");
            entity.Property(e => e.IdEmpleadoAprueva)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Empleado_Aprueva");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.NumBoleta).HasColumnName("Num_Boleta");
            entity.Property(e => e.UsuarioSystema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Systema");
            entity.Property(e => e.UsuarioWindows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Windows");
        });

        modelBuilder.Entity<VvAplicaTb>(entity =>
        {
            entity.HasKey(e => new { e.IdAplicacion, e.DiaSiembra, e.LoteSemilla })
                .HasName("PK18_1")
                .IsClustered(false);

            entity.ToTable("VV_Aplica_TB", "pd");

            entity.Property(e => e.IdAplicacion).HasColumnName("ID_Aplicacion");
            entity.Property(e => e.DiaSiembra).HasColumnName("Dia_Siembra");
            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.VvAplicaTbs)
                .HasForeignKey(d => d.IdAplicacion)
                .HasConstraintName("RefVV_Aplicacion_TB225");
        });

        modelBuilder.Entity<VvAplicacionTb>(entity =>
        {
            entity.HasKey(e => e.IdAplicacion)
                .HasName("PK14_2")
                .IsClustered(false);

            entity.ToTable("VV_Aplicacion_TB", "pd");

            entity.Property(e => e.IdAplicacion).HasColumnName("ID_Aplicacion");
            entity.Property(e => e.AplicadoPor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aplicado_Por");
            entity.Property(e => e.FechaAplicacion).HasColumnName("Fecha_Aplicacion");
            entity.Property(e => e.IdAplicadoPor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Aplicado_Por");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VvGerminacionTb>(entity =>
        {
            entity.HasKey(e => new { e.DiaSiembra, e.LoteSemilla })
                .HasName("PK13")
                .IsClustered(false);

            entity.ToTable("VV_Germinacion_TB", "pd");

            entity.Property(e => e.DiaSiembra).HasColumnName("Dia_Siembra");
            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.BandejaNueva).HasColumnName("Bandeja_Nueva");
            entity.Property(e => e.FechaMonitoreo).HasColumnName("Fecha_Monitoreo");
            entity.Property(e => e.Pgerminacion)
                .HasComputedColumnSql("(((100)*[Plantas_Reales])/[Plantas_Teoricas])", false)
                .HasColumnName("PGerminacion");
            entity.Property(e => e.PlantasReales).HasColumnName("Plantas_Reales");
            entity.Property(e => e.PlantasTeoricas).HasColumnName("Plantas_Teoricas");
        });

        modelBuilder.Entity<VvLotesSemillaTb>(entity =>
        {
            entity.HasKey(e => new { e.LoteSemilla, e.Cultivo, e.Variedad, e.Hibrido })
                .HasName("PK21_1")
                .IsClustered(false);

            entity.ToTable("VV_Lotes_Semilla_TB", "pd");

            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.HibridosTb).WithMany(p => p.VvLotesSemillaTbs)
                .HasForeignKey(d => new { d.Cultivo, d.Variedad, d.Hibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefHibridos_TB241");
        });

        modelBuilder.Entity<VvProductosAplicadosTb>(entity =>
        {
            entity.HasKey(e => new { e.IdAplicacion, e.IdProducto })
                .HasName("PK15")
                .IsClustered(false);

            entity.ToTable("VV_Productos_Aplicados_TB", "pd");

            entity.Property(e => e.IdAplicacion).HasColumnName("ID_Aplicacion");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_Producto");
            entity.Property(e => e.CantidadAplicada).HasColumnName("Cantidad_Aplicada");
            entity.Property(e => e.MotivoAplicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_Aplicacion");
            entity.Property(e => e.NombreDescriptivo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Nombre_Descriptivo");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.VvProductosAplicadosTbs)
                .HasForeignKey(d => d.IdAplicacion)
                .HasConstraintName("RefVV_Aplicacion_TB229");
        });

        modelBuilder.Entity<VvSalidaViveroTb>(entity =>
        {
            entity.HasKey(e => new { e.DiaSiembra, e.TemporadaD, e.Cultivo, e.Variedad, e.SiembraNumD, e.NombreLoteD, e.Hibrido, e.AliasLoteD, e.FechaHoraSvv, e.LoteSemilla })
                .HasName("PK19_1")
                .IsClustered(false);

            entity.ToTable("VV_Salida_Vivero_TB", "pd");

            entity.Property(e => e.DiaSiembra).HasColumnName("Dia_Siembra");
            entity.Property(e => e.TemporadaD)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Temporada_D");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiembraNumD).HasColumnName("Siembra_Num_D");
            entity.Property(e => e.NombreLoteD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Lote_D");
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AliasLoteD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alias_Lote_D");
            entity.Property(e => e.FechaHoraSvv).HasColumnName("Fecha_Hora_SVV");
            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.NumBandejasSvv).HasColumnName("Num_Bandejas_SVV");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.VvSiembraViveroTb).WithMany(p => p.VvSalidaViveroTbs)
                .HasForeignKey(d => new { d.DiaSiembra, d.LoteSemilla, d.Cultivo, d.Variedad, d.Hibrido })
                .HasConstraintName("RefVV_Siembra_Vivero_TB227");
        });

        modelBuilder.Entity<VvSemillasTb>(entity =>
        {
            entity.HasKey(e => new { e.LoteSemilla, e.Cultivo, e.Variedad, e.Hibrido, e.FechaEntrada })
                .HasName("PK120")
                .IsClustered(false);

            entity.ToTable("VV_Semillas_TB", "pd");

            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrada).HasColumnName("Fecha_Entrada");
            entity.Property(e => e.NumSemillas).HasColumnName("Num_Semillas");

            entity.HasOne(d => d.VvLotesSemillaTb).WithMany(p => p.VvSemillasTbs)
                .HasForeignKey(d => new { d.LoteSemilla, d.Cultivo, d.Variedad, d.Hibrido })
                .HasConstraintName("RefVV_Lotes_Semilla_TB245");
        });

        modelBuilder.Entity<VvSiembraViveroTb>(entity =>
        {
            entity.HasKey(e => new { e.DiaSiembra, e.LoteSemilla, e.Cultivo, e.Variedad, e.Hibrido })
                .HasName("PK12_3")
                .IsClustered(false);

            entity.ToTable("VV_Siembra_Vivero_TB", "pd");

            entity.Property(e => e.DiaSiembra).HasColumnName("Dia_Siembra");
            entity.Property(e => e.LoteSemilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Semilla");
            entity.Property(e => e.Cultivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Variedad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hibrido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CantidadSemilla).HasColumnName("Cantidad_Semilla");
            entity.Property(e => e.FechaSiembra).HasColumnName("Fecha_Siembra");
            entity.Property(e => e.NumBandejas).HasColumnName("Num_Bandejas");

            entity.HasOne(d => d.VvLotesSemillaTb).WithMany(p => p.VvSiembraViveroTbs)
                .HasForeignKey(d => new { d.LoteSemilla, d.Cultivo, d.Variedad, d.Hibrido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefVV_Lotes_Semilla_TB228");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
