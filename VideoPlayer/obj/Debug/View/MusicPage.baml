   M S B A M L   `   `   `  ����F  BVideoPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VideoPlayer.ViewVideoPlayer.View  5      =#clr-namespace:VideoPlayer.ViewModelVideoPlayer.ViewModel  5           VideoPlayer.View.MusicPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:VideoPlayer.View     5      2VM#clr-namespace:VideoPlayer.ViewModel     5        N� Title$  	MusicPage��5
       � DataContext 5      .   (VideoPlayer.ViewModel.MusicPageViewModel  5   
   6"   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      $
��Auto �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5       6!   .+�5$   
   c� $��0��6   $��0��6   $��8��6/   .@�5%      o� .@�5&      m� $��Файл��6   6+   5'      5(      r� 5/   
   -   5        $��
MainPlayer��5/   /    r� LoadedBehavior$ Manual=�6    r� Source$ /1.mp4?�6A   $��1��6Q   $��4��6^   $��0��6o   $��6��6   6�   �� 52   
   -   5        $��
TabControl��52      $��0��6(   $��4��65   $��6��6F   $��2��6V   $��50��6j   @�53      �� 54      -   5        $��PlaylistsItem��54      $��Плейлисты��6/   .��55      R� -   5        $��PlaylistsItemTreeView��55      ��6<   �� *MusicPlaylists+57      58      �� 59      -   5        $��ReviewPCItem��59   )   $��
Обзор��6   .��5:      R� -   5        $��ReviewPCItemTreeView��5:      5<      5=      5?      �� 5@   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��6��6;   $��1��6K   .+�5B      (� $��0,0,5,0q�6   .��5C      �� $��15��6   $��15��6(      PlusAddplaylist#��[  66   6a   5D      (� 5E      $��5,0,0,0q�6   .��5F      �� $��15��6   $��15��6(     MinusAddplaylist#��[ 66   6b   5G      5I      �� 5J   
   $��5��6   $��2��6"   $��8��62   $ 
Horizontal=�6F   .+�5K      (� .��5L      ��   StopButtonStyle#��[ 6   $��10��6B   $��10��6Q   $��2,2,0,2q�6_   6r   5M      (� 5N      .��5O      ��   PreviousButtonStyle#��[ 6   $��10��6F   $��10��6U   $��1q�6c   6p   5P      (� 5R      .��5S      ��   PlayButtonStyle#��[ 6   $��20��6B   $��20��6Q   6b   5T      (� 5U   
   .��5V      ��   NextButtonStyle#��[ 6   $��10��6>   $��10��6M   $��1q�6[   6h   5W      (� 5X      .��5Y      ��   MuteButtonStyle#��[ 6   $��10��6B   $��10��6Q   $��0,2,2,2q�6_   6r   5Z      �� 5\      $��Center=�6   $��Center=�63   $��30��6N   $��70��6]   6n   5^      5v      5w      