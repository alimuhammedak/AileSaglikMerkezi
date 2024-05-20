using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Personel
            builder.RegisterType<PersonelManager>().As<IPersonelService>().SingleInstance();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>().SingleInstance();

            // Ilac
            builder.RegisterType<IlacManager>().As<IIlacService>().SingleInstance();
            builder.RegisterType<EfIlacDal>().As<IIlacDal>().SingleInstance();

            builder.RegisterType<KullaniciManager>().As<IKullaniciService>().SingleInstance();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>().SingleInstance();
            // Hasta
            builder.RegisterType<HastaManager>().As<IHastaService>().SingleInstance();
            builder.RegisterType<EfHastaDal>().As<IHastaDal>().SingleInstance();

            // Doktor
            builder.RegisterType<DoktorManager>().As<IDoktorService>().SingleInstance();
            builder.RegisterType<EfDoktorDal>().As<IDoktorDal>().SingleInstance();

            // Hastalik
            builder.RegisterType<HastalikManager>().As<IHastalikService>().SingleInstance();
            builder.RegisterType<EfHastalikDal>().As<IHastalikDal>().SingleInstance();

            // HastaKayit
            builder.RegisterType<HastaKayitManager>().As<IHastaKayitService>().SingleInstance();
            builder.RegisterType<EfHastaKayitDal>().As<IHastaKayitDal>().SingleInstance();

            // Cinsiyet
            builder.RegisterType<CinsiyetManager>().As<ICinsiyetService>().SingleInstance();
            builder.RegisterType<EfCinsiyetDal>().As<ICinsiyetDal>().SingleInstance();

            // Hemsire
            builder.RegisterType<HemsireManager>().As<IHemsireService>().SingleInstance();
            builder.RegisterType<EfHemsireDal>().As<IHemsireDal>().SingleInstance();

            // Ilac
            builder.RegisterType<IlacManager>().As<IIlacService>().SingleInstance();
            builder.RegisterType<EfIlacDal>().As<IIlacDal>().SingleInstance();

            // Tetkik
            builder.RegisterType<TetkikManager>().As<ITetkikService>().SingleInstance();
            builder.RegisterType<EfTetkikDal>().As<ITetkikDal>().SingleInstance();

            // Tetkik
            builder.RegisterType<ResimYolManager>().As<IResimYolService>().SingleInstance();
            builder.RegisterType<EfResimYolDal>().As<IResimYolDal>().SingleInstance();

            // Recete
            builder.RegisterType<ReceteManager>().As<IReceteService>().SingleInstance();
            builder.RegisterType<EfReceteDal>().As<IReceteDal>().SingleInstance();

            // HastaHastalik
            builder.RegisterType<HastaHastalikManager>().As<IHastaHastalikService>().SingleInstance();
            builder.RegisterType<EfHastaHastalikDal>().As<IHastaHastalikDal>().SingleInstance();

            // Tahlil
            builder.RegisterType<TahlilManager>().As<ITahlilService>().SingleInstance();
            builder.RegisterType<EfTahlilDal>().As<ITahlilDal>().SingleInstance();

            // ReceteIlac
            builder.RegisterType<ReceteIlacManager>().As<IReceteIlacService>().SingleInstance();
            builder.RegisterType<EfReceteIlacDal>().As<IReceteIlacDal>().SingleInstance();

            //// HastaDetay
            //builder.RegisterType<HastaDetayManager>().As<IHastaDetayService>().SingleInstance();
            //builder.RegisterType<EfHastaDetayDal>().As<IHastaDetayDal>().SingleInstance();

            //// HastaDoktor
            //builder.RegisterType<HastaDoktorManager>().As<IHastaDoktorService>().SingleInstance();
            //builder.RegisterType<EfHastaDoktorDal>().As<IHastaDoktorDal>().SingleInstance();

            //// HastaIlacRapor
            //builder.RegisterType<HastaIlacRaporManager>().As<IHastaIlacRaporService>().SingleInstance();
            //builder.RegisterType<EfHastaIlacRaporDal>().As<IHastaIlacRaporDal>().SingleInstance();


            //// HastaKayitDetay
            //builder.RegisterType<HastaKayitDetayManager>().As<IHastaKayitDetayService>().SingleInstance();
            //builder.RegisterType<EfHastaKayitDetayDal>().As<IHastaKayitDetayDal>().SingleInstance();

            //// Hastalik
            //builder.RegisterType<HastalikManager>().As<IHastalikService>().SingleInstance();
            //builder.RegisterType<EfHastalikDal>().As<IHastalikDal>().SingleInstance();

            //// HastaYakin
            //builder.RegisterType<HastaYakinManager>().As<IHastaYakinService>().SingleInstance();
            //builder.RegisterType<EfHastaYakinDal>().As<IHastaYakinDal>().SingleInstance();

            //// HastaYakinlikDerece
            //builder.RegisterType<HastaYakinlikDereceManager>().As<IHastaYakinlikDereceService>().SingleInstance();
            //builder.RegisterType<EfHastaYakinlikDereceDal>().As<IHastaYakinlikDereceDal>().SingleInstance();

            //// Il
            //builder.RegisterType<IlManager>().As<IIlService>().SingleInstance();
            //builder.RegisterType<EfIlDal>().As<IIlDal>().SingleInstance();


            //// IlacOlcek
            //builder.RegisterType<IlacOlcekManager>().As<IIlacOlcekService>().SingleInstance();
            //builder.RegisterType<EfIlacOlcekDal>().As<IIlacOlcekDal>().SingleInstance();

            //// IlacRapor
            //builder.RegisterType<IlacRaporManager>().As<IIlacRaporService>().SingleInstance();
            //builder.RegisterType<EfIlacRaporDal>().As<IIlacRaporDal>().SingleInstance();

            //// Ilce
            //builder.RegisterType<IlceManager>().As<IIlceService>().SingleInstance();
            //builder.RegisterType<EfIlceDal>().As<IIlceDal>().SingleInstance();

            //// Mahalle
            //builder.RegisterType<MahalleManager>().As<IMahalleService>().SingleInstance();
            //builder.RegisterType<EfMahalleDal>().As<IMahalleDal>().SingleInstance();

            //// Oda
            //builder.RegisterType<OdaManager>().As<IOdaService>().SingleInstance();
            //builder.RegisterType<EfOdaDal>().As<IOdaDal>().SingleInstance();

            //// Olcek
            //builder.RegisterType<OlcekManager>().As<IOlcekService>().SingleInstance();
            //builder.RegisterType<EfOlcekDal>().As<IOlcekDal>().SingleInstance();
            //// Rapor
            //builder.RegisterType<RaporManager>().As<IRaporService>().SingleInstance();
            //builder.RegisterType<EfRaporDal>().As<IRaporDal>().SingleInstance();




            //// ReceteTur
            //builder.RegisterType<ReceteTurManager>().As<IReceteTurService>().SingleInstance();
            //builder.RegisterType<EfReceteTurDal>().As<IReceteTurDal>().SingleInstance();

            //// Sikayet
            //builder.RegisterType<SikayetManager>().As<ISikayetService>().SingleInstance();
            //builder.RegisterType<EfSikayetDal>().As<ISikayetDal>().SingleInstance();

            //// SikayetTur
            //builder.RegisterType<SikayetTurManager>().As<ISikayetTurService>().SingleInstance();
            //builder.RegisterType<EfSikayetTurDal>().As<ISikayetTurDal>().SingleInstance();


            //// TahlilBirim
            //builder.RegisterType<TahlilBirimManager>().As<ITahlilBirimService>().SingleInstance();
            //builder.RegisterType<EfTahlilBirimDal>().As<ITahlilBirimDal>().SingleInstance();

            //// TahlilTur
            //builder.RegisterType<TahlilTurManager>().As<ITahlilTurService>().SingleInstance();
            //builder.RegisterType<EfTahlilTurDal>().As<ITahlilTurDal>().SingleInstance();

            //// Tedarikci
            //builder.RegisterType<TedarikciManager>().As<ITedarikciService>().SingleInstance();
            //builder.RegisterType<EfTedarikciDal>().As<ITedarikciDal>().SingleInstance();



        }
    }
}
