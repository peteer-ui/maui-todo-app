# To-Do List App (.NET MAUI)

A simple cross-platform To-Do list app built with .NET MAUI while learning mobile development.

## Features
- Add a task with the Add button or the Enter key
- Swipe a task left and tap Delete to remove it
- Empty tasks are ignored

## Tech Stack
- C#
- .NET 9, .NET MAUI
- XAML (Grid, Entry, Button, CollectionView, SwipeView)

## What I Learned
- Building layouts with Grid and XAML
- Connecting UI events to C# code-behind (`Clicked`, `Invoked`, `Completed`)
- Using `ObservableCollection` so the list updates automatically

## Run
1. Install Visual Studio 2022 with the ".NET Multi-platform App UI development" workload
2. Open `first_app.csproj`
3. Choose Android Emulator or Windows Machine and press Run

## Next Steps
- Save tasks locally (SQLite or Preferences)
- Mark tasks as done
- Move to MVVM
