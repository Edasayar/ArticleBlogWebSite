using ArticleBlogSiteEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class ArticleTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                   .UseIdentityColumn(1, 1);

            builder.Property(x => x.Title).HasMaxLength(200);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);



            //builder.HasOne(x => x.Rating).
            //   WithMany(x => x.Articles).HasForeignKey(x => x.RatingId).OnDelete(DeleteBehavior.NoAction);

            _ = builder.HasData(new Article
            {
                ID = 1,
                Title = "Başkasının Üzüntüsüne Sevinme",
                Content = "Crysel (2014), sosyal yaşamda çeşitli talihsiz olaylar karşısında başkasının üzüntüsüne sevinme duygusunun bir kişilik özelliği olarak ele alınabileceğini ileri sürmüştür. Bu doğrultuda, iyicil ve kötücül başkasının üzüntüsüne sevinme olmak üzere iki faktöre sahip ve toplam 12 maddeden oluşan bir ölçek geliştirmiştir. Bu çalışmanın amacı Crysel (2014) tarafından Amerikan örnekleminde geliştirilen Başkasının Üzüntüsüne Sevinme Ölçeği’ni Türkçeye uyarlamak ve psikometrik özelliklerini incelemektir. Bu çalışmanın örneklemini 379 üniversite öğrencisi (183 erkek, 196 kadın, Ort.yaş = 20.6, SS = 2.48) oluşturmaktadır. Başkasının Üzüntüsüne Sevinme Ölçeği’ne ek olarak katılımcılara geçerlik sınamaları kapsamında Toronto Empati Ölçeği ve BeMaS- Haset ve Gıpta Ölçeği de verilmiştir. Psikometrik sınamalar kapsamında madde analizi, doğrulayıcı faktör analizi, diğer yapılarla ilişkiler ve güvenirlik için tutarlık analizi uygulanmıştır. Madde analizi, ölçek maddelerinin madde toplam korelasyon katsayılarının uygun değerlere sahip olduğunu göstermektedir (.27- .46). Doğrulayıcı faktör analizleri sonucunda toplam beş model sınanmış ve elde edilen bulgular ölçeğin Türkçe formunun yeterli uyum değerlerine sahip olduğunu ve orijinal ölçek ile benzer faktör yapısına sahip olduğunu göstermiştir. ",
                CategoryId = 1,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                ViewCount = 20,
                Image = @"\images\dalga-geçmek.jpg",
               UserId = -1, //admin




            },
            new Article
            {
                ID = 2,
                Title = "Pandemide Yas: Dini ve Kültürel Ritüellerini Yerine Getiremeyen Bireylerin Deneyimleri",
                Content = "COVID-19 pandemisi nedeniyle birçok kayıp yaşanmış ve artan ölüm sayıları nedeniyle pandemiyi kontrol edebilmek için çeşitli kısıtlamalar ve karantinalar ilan edilmiştir. Bu kısıtlamalar ve karantinalar nedeniyle bireyler günlük ve sosyal yaşamlarında birçok değişiklikle karşılaşırken yaşadıkları kayıp sonrasında gerçekleştirdikleri dini ve kültürel ritüelleri de yerine getirememişlerdir. Alan-yazında kişilerin yaşadıkları kaybın ardından gerçekleştirmek istedikleri dini ve kültürel ritüelleri gerçekleştirmelerinin, kişilerin yas sürecinde olumlu bir etkiye sahip olduğu ele alınmıştır. Bu bağlamda bu araştırma, COVID-19 pandemisi sürecinde Türk toplumunda COVID-19 nedeniyle kayıp yaşayan ancak kısıtlamalar nedeniyle dini ve kültürel ritüelleri yerine getiremeyen bireylerin bu süreci nasıl deneyimlediklerini araştırmaktadır. Bu amaçla bireylerin öznel deneyimlerinin anlaşılabilmesi için 45-65 yaş arasında, son bir yıl içerisinde COVID-19 nedeniyle bir yakınını kaybetmiş dört katılımcı ile yarı yapılandırılmış görüşmeler yapılmış ve bu görüşmeler Yorumlayıcı Fenomenolojik Analiz yöntemi ile analiz edilmiştir. Analizin sonucunda beş üst tema oluşturulmuştur: Ritüellerin eksikliğinde olumsuz duygular, Yas sürecini kolaylaştırması açısından ritüellere yapılan atıflar, Kayıpla baş etme yöntemleri, Gerçekleşmeyen ritüellerin telafisi ve Yasaklara rağmen: Ritüelleri gerçekleştirebilmek. Bu temalar Lacanyen psikanalitik bakış açısı ile simgesel, imgesel ve gerçek kavramları bağlamında değerlendirilmiştir. Simgesel düzlem özne için dil, kültür ve sosyal ortam olarak tanımlanırken imgesel düzlem öznenin içsel dünyalarında gerçeği anlamlandırdıkları düzlem olarak tanımlanabilir. Bu nedenle dini ve kültürel ritüellerin toplumsal, kültürel ve sosyal işlevi de göz önünde bulundurulduğunda katılımcıların yas sürecinde kayıplarını adlandırma ve kabul etme konusunda simgesel anlamda bir eksiklik yaşadıkları ve kaybı imgesel düzlemde anlamlandırmaya çalıştıkları düşünülmüştür. Bu bağlamda katılımcıların geliştirdikleri alternatif telafi yöntemleri kültürde ve toplumsal düzende, başka bir deyişle simgeselde kendilerine yer bulma çabası olarak yorumlanmıştır.",
                CreatedDate = DateTime.Now,
                CategoryId = 1,
                CreatedBy = "dilo",
                IsDeleted = false,
                ViewCount = 46,
                Image = @"\images\1.jpg",
                UserId = -2 //dilo
            },
             new Article
             {
                 ID = 3,
                 Title = "Kantçı ve feminist etik kuramlarda bireysel özerklik tartışması",
                 Content = "Bu makalenin amacı koruyucu etiğin moral temelini tanıtmak, koruyucu etik ile Kantçı etik yaklaşımların özerklik bağlamında farklılıklarını irdelemek; koruyucu etiğe en uygun bireysel özerklik kuramının ne olabileceği sorusunu araştırmaktır. Feminist özerklik anlayışına getirilen eleştirileri karşılamaya çalışırken Meyers’in geliştirdiği yeterlilik temelli özerklik anlayışının aslında Kant’ın karşı çıktığı geleneksel özerklik anlayışıyla temelde benzer olduğunu göstermeye çalışacağım. Yeterlilik temelli özerklik yaklaşımının bazı boyutlarında Kantçı anlamda özerk olmak mümkün olsa da bu durum koruyucu eylemlerin Kantçı anlamda özerk eylemler olduğunu ve etik değere sahip olduklarını göstermez. Bu iki özerklik anlayışı temelde farklıdır. Bu farklılık, özerkliğin değeri ile diğer bazı etik değerler arasındaki öncelik konusundaki yaklaşımdan kaynaklanmaktadır. Kantçı yaklaşıma göre feminist yaklaşım özerkliği bazı yaderklik koşullarında aramaktadır. Feminist etiğe göre ise Kant’ın yaderklik olarak gördüğü bu durumlarda önemli etik değerler vardır.",
                 CreatedDate = DateTime.Now,
                 CategoryId = 2,
                 CreatedBy = "selino",
                 IsDeleted = false,
                 ViewCount = 3,
                 Image = @"\images\28-1.jpg",
                 UserId = -3

             },
              new Article
              {
                  ID = 4,
                  Title = "DĒMOKRATIA - OLIGARKHIA: ERKEN HELLENİSTİK DÖNEM’E DEĞİN DEMOKRASİ VE OLİGARŞİNİN TARİHSEL GELİŞİMİ",
                  Content = "Siyasal egemenliğe ilişkin temel kavramlardan olan dēmokratia (demokrasi) ve oligarkhia (oligarşi), anayasal yönetim biçimleri olarak antik Hellen siyasi coğrafyasının tarihi koşulları içinde ortaya çıkmıştır. Arkaik Dönem’in farklı polis merkezlerinde, kısmen birbirine koşut olarak ortaya çıkmalarının ardından bu iki yönetim biçimi, değişen devletlerarası dengelerin bir sonucu olarak zaman içinde büyüyen kırılmalarla birbirinden uzaklaşmaya başlamış ve nihayet Erken Hellenistik Dönem ile birlikte yeni siyasi konjonktür içinde sadece dēmokratia, polis için arzu edilen siyasal düzen olarak öne çıkmıştır. Konu edilen bu tarihi süreç, mevcut çalışmada özgün edebi ve epigrafik belgelere dayalı olarak antik Hellen siyasal dünyasının yoğunlukla devletlerarası dinamikleri ile devlet ideolojileri ekseninde ele alınmaktadır. Araştırmada uygulanan karşılaştırmalı yöntem sayesinde dēmokratia’nın hangi tarihi koşullarda oligarkhia’yı aştığını ve yaklaşık İÖ 3. yüzyılın başlarında en iyi sivil yönetim biçimi olarak kabul edilmeye başlandığını ortaya koymak amaçlanmaktadır.",
                  CreatedDate = DateTime.Now,
                  CategoryId = 3,
                  CreatedBy = "dilo",
                  IsDeleted = false,
                  ViewCount = 57,
                  Image = @"\images\8-.jpg",
                  UserId = -2

              },
               new Article
               {
                   ID = 5,
                   Title = "HOMEROS DESTANLARINDA DOSTLUK ANLAYIŞI: PHILOS VE KSEINOS KAVRAMLARI",
                   Content = "Bu çalışma Homeros destanlarında philos ve kseinos kavramlarının incelenmesi yoluyla Homeros toplumunun kök değerlerinden biri olan dostluk anlayışına odaklanmaktadır. Çalışma üç ana bölümden oluşmaktadır: ilkin, philos’un iyelikten duygusal anlama uzanan semantik gelişimiyle ilgili tartışmalara ve değerlendirmelere yer verilmekte; ikincil olarak, “dost” anlamına gelen philos sözcüğü Homeros dünyasına özgü agathos’la ilişkisi bağlamında ele alınmakta ve son olarak dostluk olgusunu tamamlayacak bir başka kol olan “konuk-dost” anlamında kseinos sözcüğünün kullanımı işlenmektedir. Günümüzdeki gönüllü ve duygu yüklü dostluk anlayışından farklı olarak, Homeros’un anlattığı toplumda dostluk, çoğu zaman duygusal etkileşimin öncelikli olmadığı, yaşam koşullarının ve toplumsal ihtiyaçların yönlendirdiği bir ilişki biçimini imgeler. Farklı şekilde pratik edilmelerine rağmen philia’nın alt kümeleri sayılan philos (dost) ve kseinos (konuk-dost) kavramları dostluğun sosyal ve kurumsal boyutuna işaret eder. Polis’in henüz bir devlet birimi olarak olgunlaşmadığı ve bir mekân topluluğunu ifade ettiği bu tarihsel süreçte, philos ve kseinos’un Homeros’un anlattığı toplumun bey soylu üyelerini ayakta tutan dinamiklerden biri olduğu anlaşılmaktadır.",
                   CreatedDate = DateTime.Now,
                   CategoryId = 3,
                   CreatedBy = "selino",
                   IsDeleted = false,
                   ViewCount = 34,
                   Image = @"\images\homeros-kimdir.jpg",
                   UserId = -3

               },

                new Article
                {
                    ID = 6,
                    Title = "5G, Nesnelerin İnternetini Nasıl Etkileyecek?",
                    Content = "Yeni nesil mobil internet teknolojisi 5G, tahminlere göre Güney Kore'de 2020 yılından itibaren kullanılmaya başlanacak. Daha önceki mobil veri teknolojilerinde gördüğümüz geçiş dönemine baktığımızda, 5G'nin global olarak gelişmiş ülkelerde kullanılmaya başlanması ve sistemin stabil bir hale getirilmesinin ise 2022 yılı gibi gerçekleşeceği öngörülüyor. Fakat bu teknolojiye alışamadan Koronavirüs (Covid-19) ile birlikte 5G tartışmaları başladı. Peki gerçekten 5G ve Koronavirüs arasında bağlantı var mı? Önümüzde 5G için çok kısa olmayan bir süre var. Global olarak kullanılmaya devam eden 4G / LTE teknolojilerine göre 5G, nesnelerin internetine ne gibi katkılarda bulunacak?\r\n\r\n5G, neler vaat ediyor?\r\nMühendisler, 5G'nin tam olarak hazır hale geldiğinde günümüzdeki hücresel bağlantı sistemlerine göre 1000 kat daha fazla mobil veriyi yönetebileceğini belirtiyorlar. Ayrıca satış makineleri, arabalar, ev eşyaları gibi hem sabit hem de haraketli sistemleri birbirine bağlamada dev bir iskelet görevi göreceği tahmin ediliyor. Genel olarak ekonomistler ve mühendisler bu gelişmelerin ekonomik devrimler yaratacağını öne sürüyor. Bunu mümkün kılacak olan ise yeni teknolojiler, yeni mimariler ve yeni donanımlar olacak. Lancaster Üniversitesindeki bir araştırma ekibi ve Çin’deki Southwest Jiaotong Üniversitesinden bir araştırma ekibi son gelişmelere bakarak, 5G’nin gelecekteki ihtiyaçları ile ilgili bir makale yayınladılar.  Biz de bu makale ışığında 5G ve nesnelerin internetine ışık tutmaya çalışıyoruz.",
                    CreatedDate = DateTime.Now,
                    CategoryId = 4,
                    CreatedBy = "selino",
                    IsDeleted = false,
                    ViewCount = 36,
                    Image = @"\images\5g-iot-ana.jpg",
                    UserId = -3

                }




            );
        }
    }
}
