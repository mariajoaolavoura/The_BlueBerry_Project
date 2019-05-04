package com.bluebudget.bluebugdet;

import android.util.Log;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.Map;

public class App {


    boolean firstUse = true;

    private AppCategoryList categories;
    private AppWalletList wallets;
    private AppTransactionList transactions;


    private static final String TAG = "App";


    public App(){
        this.transactions = new AppTransactionList();
        this.wallets = new AppWalletList();
        this.categories = new AppCategoryList();

        addWallet("Current", R.drawable.ic_account_balance_wallet_black_24dp, -1.0);
        addWallet("Future Expenses", R.drawable.ic_account_balance_wallet_black_24dp, -1.0);
        addWallet("Savings",R.drawable.ic_account_balance_wallet_black_24dp, -1.0);

        addCategory(null, "Income", R.drawable.ic_trending_up_black_24dp, 0.0, 1, AppBudgetType.INCOME);
        addCategory("Income", "Income: gifts", R.drawable.ic_trending_up_black_24dp, 0.0, 1, AppBudgetType.INCOME);
        addCategory(null, "Home", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory("Home", "Home: cleaning products", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Food", R.drawable.ic_shopping_cart_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Transports", R.drawable.ic_directions_car_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);


        addCategory(null, "Home1", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home2", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home3", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home4", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home5", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home6", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home7", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home8", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home9", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home0", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home11", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home22", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);
        addCategory(null, "Home33", R.drawable.ic_home_black_24dp, 0.0, 1, AppBudgetType.EXPENSE);





    }



    // ---------------------------------------------------------------------------------------------
    // CATEGORIES ----------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------
    public AppCategory getCategory(String name){
        return categories.getCategory(name);
    }

    public void addCategory(String parent, String name, int icon, double defBudget, int defRecurrence, AppBudgetType type) {
        categories.addCategory(parent, name, icon, defBudget, defRecurrence, type);
    }

    public void updateCategory(String name, double defBudget, int defRecurrence) {
        categories.updateCategory(name, defBudget, defRecurrence);
    }

    public void removeCategory(String name){
        categories.removeCategory(name);
    }

    public List<AppCategory> getCategoriesList(){
        return categories.getCategories();
    }

    public Map<AppCategory,List<AppCategory>> getCategoriesAndSubCategoriesDict(){
        return categories.getCategoriesAndSubCategories();
    }

    public List<AppCategory> filterCategories(List<String> parentsList,
                                              List<AppBudgetType> typesList){
        return categories.filterCategories(parentsList, typesList);
    }

    public List<AppCategory> filterCategories(String parent,
                                              AppBudgetType type){
        List<String> parentsList = new ArrayList<>();
        parentsList.add(parent);
        List<AppBudgetType> typesList = new ArrayList<>();
        typesList.add(type);
        return categories.filterCategories(parentsList, typesList);
    }

    public List<AppCategory> filterCategories(String parent){
        List<String> parentsList = new ArrayList<>();
        parentsList.add(parent);
        return categories.filterCategories(parentsList, null);
    }

    public List<AppCategory> filterCategories(AppBudgetType type){
        List<AppBudgetType> typesList = new ArrayList<>();
        typesList.add(type);
        return categories.filterCategories(null, typesList);
    }


    public List<AppCategory> allCatTypeOrdered(AppBudgetType type){
        return categories.allCatTypeOrdered(type);
    }

    public String getCategoryFirstName(String originalName){
        String newName=originalName;
        if(getCategory(originalName)==null){
            return newName;
        }
        else if(getCategory(originalName).getParent()!=null){
            Log.i(TAG, originalName);
            String [] s = originalName.split(": ");
            newName=s[1];
            Log.i(TAG, newName);
        }
        return newName;
    }

    public String newSubCategoryFullName(String parentName, String subcatName){
        return parentName+": "+subcatName;
    }




    // ---------------------------------------------------------------------------------------------
    // WALLETS -------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------

    public void addWallet(String name, int icon, Double initialBalance){
        wallets.addWallet(name, icon, initialBalance);
    }

    public void removeWallet(String name) {
        wallets.removeWallet(name);
    }

    // does nothing for the moment
    public void updateWallet(String walletName) {
        wallets.updateWallet(walletName);
    }

    public List<AppWallet> getWalletsList(){
        return wallets.getWalletsList();
    }


    // ---------------------------------------------------------------------------------------------
    // TRANSACTIONS --------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------

    public void addIncome(double value, Calendar date, AppCategory category, String notes , String location,
                          String wallet) {
        transactions.addIncome(value, date, category, notes , location, wallet);
    }

    public void addExpense(double value, Calendar date, AppCategory category, String notes , String location,
                           String wallet) {
        transactions.addExpense(value, date, category, notes , location, wallet);
    }

    public void addTransfer(double value, Calendar date, String notes , String location,
                          String wallet, String recipientWallet) {
        transactions.addTransfer(value, date, notes , location, wallet, recipientWallet);
    }

    public List<AppTransaction> getTransactions(Calendar minDate, Calendar maxDate,
                                                   List<String> categoryNames,
                                                   List<String> locations,
                                                   List<String> wallets,
                                                   AppTransactionType type) {

        return transactions.filterTransactions(minDate, maxDate, categoryNames, locations, wallets, type);
    }


    public double calculateBalance(List<AppTransaction> transactions){
        return AppTransactionList.calculateBalance(transactions);
    }



}
