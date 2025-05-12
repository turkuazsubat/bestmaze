-----BESTMAZE
# 🧠 Yapay Zeka Ajanı ile Görsel Yol Bulma (C# .NET Framework)

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş, koşul tabanlı bir yapay zeka ajanının 10x10'luk görsel bir harita üzerinde yol bulma algoritmasını simüle ettiği bir çalışmadır. Proje, kullanıcı tarafından tanımlanan başlangıç, bitiş ve engel noktalarına göre hareket eden bir ajanın, belirli kurallara göre çıkışı bulmasını sağlar.

## 🚀 Özellikler

- Görsel arayüz: Windows Forms üzerinde 10x10 PictureBox dizisiyle harita çizimi
- Kullanıcı etkileşimi: Tıklanarak başlangıç, bitiş, yol ve engel tanımlaması
- Koşullu karar veren ajan (fare görselli): 
  - Sağ → Yukarı → Sol → Aşağı şeklinde yön önceliği
  - Çıkmaz durumunda geri çekilme ve yol silme
  - Yol ayrımlarında hafızaya "checkpoint" alma
  - Geriye ışınlanarak alternatif yolları deneme
- Hareket adımı sayısına göre puanlama
- Dinamik harita, rastgele kullanıcı girişiyle oluşturulabilir
- `Timer` kullanımı ile adım adım ajan simülasyonu

## 🧠 Kullanılan Yapay Zeka Yaklaşımları

Bu projede doğrudan makine öğrenmesi teknikleri kullanılmasa da, klasik yapay zekanın temel yaklaşımlarından bazıları uygulanmıştır:

- **Kural Tabanlı Sistemler**: Ajanın hareketi tamamen "if-else" koşullarıyla modellenmiştir.
- **Deterministik Ajan**: Ajan, bulunduğu duruma göre her zaman aynı eylemi yapar.
- **Arama Tabanlı Problem Çözümü (Exploration)**: Ajan, hedefe ulaşmak için sistematik bir arama yapar.
- **Geri İzleme (Backtracking)**: Çıkmaza girildiğinde önceki duruma dönülerek alternatif yollar denenir.
- **Hafıza Kullanan Ajan**: Checkpoint özelliğiyle geçmişteki karar noktaları hatırlanır.
- **Heuristik Olmayan Yol Bulma**: Sabit kurallara dayalı, bilgiye dayalı olmayan basit arama stratejileri

## 🛠️ Teknolojiler

- C# (.NET Framework 4.5)
- Windows Forms
- Timer sınıfı ile zaman kontrollü döngü
- GDI+ ile temel görselleştirme (fare ikonu, yol boyama vb.)

## 🖥️ Kurulum

1. Proje klasörünü indirin veya klonlayın:
   ```bash
   git clone https://github.com/turkuazsubat/bestmaze.git
