# Caching
* Web sitesindeki js, css vb. dosyaları versiyonlama yapan kütüphane projesidir.
* Güncel Sürüm: Caching-19.6.1.19
* .NET Framework 4.7.2 projesidir.

## Kullanımı
* Normal şartlarda web projemize herhangi bir js, css vb. dosyaları aşağıdaki gibi ekliyoruz.
```
<link rel="stylesheet" href="~/Content/bootstrap.min.css" />
```

* Versiyonlama yapmak için kütüphaneyi projemize ekliyoruz. Ve projemizdeki js, css vb. dosyaları aşağıdaki gibi güncelliyoruz.
```
<link rel="stylesheet" href="@Html.VersiyonEkle("Content/bootstrap.min.css")" />
```

* VersiyonEkle metodu da bootstrap.min.css dosyasının adına ?v=DOSYANIN SON DEĞİŞİKLİK TARİHİNİ ekliyor. Haliyle biz .css dosyasında bir güncelleme yaptığımızda sitenin eski .css'i yükleme sorunu çözülüyor.