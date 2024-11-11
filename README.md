# .NET MAUI Application Analysis - ProsperDaily
## 🛠 Development Environment Setup

```markdown
Required Tools:
- Visual Studio 2022
- JetBrains Rider
- .NET 7.0 or later
- MAUI Workload
- Android/iOS SDKs (for mobile development)
```
---
## 📝 Nuget Package
```markdown
- Syncfusion.Maui.Charts
- Humanizer
- PropertyChanged.Fody
- sqlite-net-pcl
- SQLiteNetExtensions
- SQLitePCLRaw.provider.dynamic_cdecl
```
---
## 📂 Core Components - Project Structure
```markdown
- ProsperDaily/
  ├── Dependencies/
  ├── Properties/
  ├── Abstractions/
  │   ├── IBaseRepository.cs
  │   └── TableData.cs
  ├── Converters/
  │   ├── AmountToColorConverter.cs
  │   └── AmountToCurrencyConverter.cs
  ├── MVVM/
  │   ├── Models/
  │   │   ├── Transaction.cs
  │   │   └── TransactionsSummary.cs
  │   ├── ViewModels/
  │   │   ├── DashboardViewModel.cs
  │   │   ├── StatisticsViewModel.cs
  │   │   └── TransactionsViewModel.cs
  │   ├── Views/
  │       ├── AppContainer.xaml
  │       │   └── AppContainer.xaml.cs
  │       ├── DashboardPage.xaml
  │       │   └── DashboardPage.xaml.cs
  │       ├── StatisticsPage.xaml
  │       │   └── StatisticsPage.xaml.cs
  │       ├── TransactionPage.xaml
  │           └── TransactionPage.xaml.cs
  ├── Platforms/
  ├── Repositories/
  │   └── BaseRepository.cs
  ├── Resources/
  │   ├── App.xaml
  │   │   └── App.xaml.cs
  │   ├── AppShell.xaml
  │   ├── Constants.cs
  │   ├── FodyWeavers.xml
  │   ├── MainPage.xaml
  │   └── MauiProgram.cs
```

---
## ⭐️ Analysis of


---
## 🎯 .Net Maui Code :
