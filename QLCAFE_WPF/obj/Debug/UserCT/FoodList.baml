   M S B A M L   `   `   `  ����E  AQLCAFE_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:QLCAFE_WPF.ViewmodelQLCAFE_WPF.Viewmodel  5      'clr-namespace:QLCAFE_WPF
QLCAFE_WPF  6       QLCAFE_WPF.UserCT.FoodList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8	Viewmodel"clr-namespace:QLCAFE_WPF.Viewmodel     5      f bDevExpress.Xpf.Grid.v17.1.Core, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   6C   ] YDevExpress.Mvvm.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   6�   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6�   )
QLCAFE_WPFclr-namespace:QLCAFE_WPF  6  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6.    � DataContext  5	      (   "QLCAFE_WPF.Viewmodel.FoodViewModel  5
   
   2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors 5      /  )DevExpress.Xpf.Core.DXSplashScreenService  5   
      SplashScreenType"   QLCAFE_WPF.SplashScreenView1"  6#       ShowSplashScreenOnLoading . 6\   .��5      � .+�5   
   %  DevExpress.Xpf.Grid.GridControl  -   5          Name$ gridControl��5      )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$
 None=�60      SelectionMode$
 Cell=�6�   $��0,0,0,54q�6�   $��2��6�      
ShowBorder .     ItemsSource 6K   �� *ObsFoodCategory+	 �� Mode$	 OneTime=�
   Bands
 5      )  #DevExpress.Xpf.Grid.GridControlBand  5      $  DevExpress.Xpf.Grid.BaseColumn   Header)	  #DevExpress.Xpf.Core.ObjectConverter$ Danh sách nhóm	 6&      Columns. 5      $
  DevExpress.Xpf.Grid.GridColumn
  $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ id��6%   $ Mã Số	 64      	SortOrder$ 	Ascending=�6C      	SortIndex$ 0��6Y   
  5      $
 name��6%   $ Mã Số	 66   5         View 5      #  DevExpress.Xpf.Grid.TableView  5      -   5        $��table��5       &   DevExpress.Xpf.Grid.DataViewBase   AllowEditing .    AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.GridViewBase   ShowGroupPanel .     	AutoWidth .    ShowTotalSummary . 6�   5       �� 5!   
   $��Button��6   $��	44,0,0,11q�6"   $��22��6[   $��Bottom=�6g   $
��Left=�6�   $��75��6�   ��65   �� *dgFoodChangeIndex+6�   �� 5"   
   $��Thêm dòng��6   $��
159,0,0,10q�6%   $��22��6T   $��Bottom=�6`   $
��Left=�6{   $��98��6�   ��69   �� *Addrow+��6�   ��  �� ElementName$ table��5#      5$      