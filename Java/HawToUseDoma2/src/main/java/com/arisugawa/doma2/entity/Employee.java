package com.arisugawa.doma2.entity;

import org.seasar.doma.Column;
import org.seasar.doma.Entity;
import org.seasar.doma.GeneratedValue;
import org.seasar.doma.GenerationType;
import org.seasar.doma.Id;
import org.seasar.doma.Table;

/**
 */
@Entity(listener = EmployeeListener.class)
@Table(name = "employee")
public class Employee {

    /** */
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    Integer id;

    /** */
    @Column(name = "fullname")
    String fullname;

    /** */
    @Column(name = "age")
    Integer age;

    /** 
     * Returns the id.
     * 
     * @return the id
     */
    public Integer getId() {
        return id;
    }

    /** 
     * Sets the id.
     * 
     * @param id the id
     */
    public void setId(Integer id) {
        this.id = id;
    }

    /** 
     * Returns the fullname.
     * 
     * @return the fullname
     */
    public String getFullname() {
        return fullname;
    }

    /** 
     * Sets the fullname.
     * 
     * @param fullname the fullname
     */
    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    /** 
     * Returns the age.
     * 
     * @return the age
     */
    public Integer getAge() {
        return age;
    }

    /** 
     * Sets the age.
     * 
     * @param age the age
     */
    public void setAge(Integer age) {
        this.age = age;
    }
}