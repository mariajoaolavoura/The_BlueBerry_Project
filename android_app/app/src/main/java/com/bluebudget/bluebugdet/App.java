package com.bluebudget.bluebugdet;

import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Set;

public class App {


    boolean firstUse = true;

    private AppCategoryList categories;
    private AppWalletList wallets;
    private AppTransactionList transactions;



    public App(){
        this.transactions = new AppTransactionList();
        this.wallets = new AppWalletList();
        this.categories = new AppCategoryList();

        wallets.addWallet("Current", -1.0);
        wallets.addWallet("Savings", -1.0);
    }


    // ---------------------------------------------------------------------------------------------
    // CATEGORIES ----------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------
    public AppCategory getCategory(String name){
        return categories.getCategory(name);
    }

    public void addCategory(String parent, String name, int icon, double defBudget, double defRecurrence) {
        categories.addCategory(parent, name, icon, defBudget, defRecurrence);
    }

    public void updateCategory(String name, double defBudget, double defRecurrence) {
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


    // ---------------------------------------------------------------------------------------------
    // WALLETS -------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------

    public void addWallet(String name, Double initialBalance){
        wallets.addWallet(name, initialBalance);
    }

    public void removeWallet(String name) {
        wallets.removeWallet(name);
    }

    // does nothing for the moment
    public void updateWallet(String walletName) {
        wallets.updateWallet(walletName);
    }


    // ---------------------------------------------------------------------------------------------
    // TRANSACTIONS --------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------

    public void addIncome(double value, Date date, String category, String notes , String location,
                          String wallet, String recipientWallet) {
        transactions.addIncome(value, date, category, notes , location, wallet, recipientWallet);
    }

    public void addExpense(double value, Date date, String category, String notes , String location,
                          String wallet, String recipientWallet) {
        transactions.addExpense(value, date, category, notes , location, wallet, recipientWallet);
    }

    public void addTransfer(double value, Date date, String category, String notes , String location,
                          String wallet, String recipientWallet) {
        transactions.addTransfer(value, date, category, notes , location, wallet, recipientWallet);
    }

    public List<AppTransaction> getTransactions(Date minDate, Date maxDate,
                                                   List<Integer> categoryIDs,
                                                   List<String> locations,
                                                   List<String> wallets) {

        return transactions.filterTransactions(minDate, maxDate, categoryIDs, locations, wallets);
    }


    public double calculateBalance(List<AppTransaction> transactions){
        return AppTransactionList.calculateBalance(transactions);
    }



}